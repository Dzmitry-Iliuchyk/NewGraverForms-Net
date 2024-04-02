namespace NewGraverForms_Net.Tools
{
    public class TabControlHelper
    {
        public Action OnFirstPage;
        public Action OnLastPage;
        public Action OnPageChanged;
        private TabControl _tabControl;
        private Dictionary<int, TabPage> _pagesIndexed;
        private bool isLastPage = false;
        private bool isFirstPage = false;
        private int currentIndex;
        public int CurrentIndex
        {
            get
            {
                if (_tabControl.TabPages.Count > 1)
                {
                    var currentTab = _tabControl.SelectedTab;
                    return _pagesIndexed.First(t => t.Value == currentTab).Key;
                }
                return currentIndex;
            }
            set
            {
                if (value == 0)
                {
                    IsFirstPage = true;
                }
                else if (value == _pagesIndexed.Count - 1)
                {
                    IsLastPage = true;
                }
                else
                {
                    IsLastPage = false;
                    IsFirstPage = false;
                }
                currentIndex = value;
            }
        } 

        public bool IsLastPage { get => isLastPage; set 
            { 
                isLastPage = value;
                if (value == true)
                {
                    OnLastPage?.Invoke();
                }
                
            } 
        }

        public bool IsFirstPage { get => isFirstPage;
            set {
                isFirstPage = value;
                if (value == true)
                {
                    OnFirstPage?.Invoke();
                }
            }
        }

        public TabControlHelper(TabControl tabControl)
        {
            _tabControl = tabControl;
            _pagesIndexed = new Dictionary<int, TabPage>();

            for (int i = 0; i < _tabControl.TabPages.Count; i++)
            {
                _pagesIndexed.Add(i, _tabControl.TabPages[i]);
            }
        }
        public void ShowNextOne()
        {
            OnPageChanged.Invoke();
            if (_tabControl.TabPages.Count != 0)
            {
                CurrentIndex += 1;
            }
            else
                CurrentIndex = 0;
            HideAllPages();
            ShowPage(CurrentIndex);
        }

        public void ShowPrevOne()
        {
            OnPageChanged.Invoke();
            CurrentIndex -= 1;
            HideAllPages();
            ShowPage(CurrentIndex);
        }

        public void HideAllPages()
        {
            _tabControl.TabPages.Clear();
        }

        public void ShowAllPages()
        {
            _tabControl.TabPages.Clear();
            _tabControl.TabPages.AddRange(_pagesIndexed.Values.ToArray());
        }

        public void HidePage(TabPage tabPage)
        {
            if (!_tabControl.TabPages.Contains(tabPage))
                return;
            _tabControl.TabPages.Remove(tabPage);
        }

        public void ShowPage(TabPage tabPage)
        {
            if (_tabControl.TabPages.Contains(tabPage))
                return;
            Dictionary<int, TabPage> dictItems = new();
            var currentTab = _pagesIndexed
                .Where(x => x.Value == tabPage)
                .FirstOrDefault();
            dictItems.Add(currentTab.Key, currentTab.Value);
            for (int i = 0; i < _tabControl.TabPages.Count; i++)
            {
                dictItems.Add(i, _tabControl.TabPages[i]);
            }
            _tabControl.TabPages.Clear();
            _tabControl.TabPages
                .AddRange(dictItems.OrderByDescending(x => x.Key).Select(x => x.Value)
                .ToArray());
        }

        public void ShowPage(int index)
        {
            if (index > _pagesIndexed.Count - 1 || index < 0)
                return;
            Dictionary<int, TabPage> dictItems = new();
            var currentTab = _pagesIndexed
                .Where(x => x.Key == index)
                .FirstOrDefault();
            dictItems.Add(currentTab.Key, currentTab.Value);
            for (int i = 0; i < _tabControl.TabPages.Count; i++)
            {
                dictItems.Add(i, _tabControl.TabPages[i]);
            }
            _tabControl.TabPages.Clear();
            _tabControl.TabPages
                .AddRange(dictItems.OrderByDescending(x => x.Key).Select(x => x.Value)
                .ToArray());
        }
    }
}
