using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml.Data;

namespace ListView
{
    class Model
    {
    }

    class IncrementalObservableCollection<T> : ObservableCollection<T>, ISupportIncrementalLoading
    {
        public IncrementalObservableCollection()
            : base()
        {
        }

        public IncrementalObservableCollection(IEnumerable<T> collection)
            : base(collection)
        {
        }

        private bool hasMoreItems = true;
        public bool HasMoreItems
        {
            get { return hasMoreItems; }
            private set { hasMoreItems = value; }
        }

        public IAsyncOperation<LoadMoreItemsResult> LoadMoreItemsAsync(uint count)
        {
            throw new NotImplementedException();
        }
    }
}
