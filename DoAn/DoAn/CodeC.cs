using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public class CodeC
    {
        public static ListBox codeListBox;
        public static TextBox yTuongTextBox;
        public static string[] ChuyenText(string text)
        {
            string[] texts;
            texts = text.Split('\n');
            return texts;
        }

        /// <summary>
        /// code sort
        /// </summary>
        /// 
        #region SelectionSort
        public static void SelectionSort(bool tang = true)
        {
            string yTuong = @"Chọn phần tử nhỏ nhất hoặc lớn nhất trong N phần tử trong dãy hiện hành. Đưa phần tử này về vị trí đầu dãy hiện hành. Xem dãy hiện hành chỉ còn N-1 phần tử của dãy hiện hành ban đầu. Bắt đầu từ vị trí thứ 2. Lặp lại quá trình trên cho dãy hiện hành... đến khi dãy hiện hành chỉ còn 1 phần tử";
            string[] code = ChuyenText(
@"Sắp tăng:
void SelecttionSort(int arr[], int N)
{
    int min, i, j;
    for (i=0; i < N-1; i++)
    {
        min = i;
        for (j=i+1; j <N; j++)
            if (a[j] < a[min])
                    min=j;
        Swap(a[min], a[i]);   
    } 
}");

            //add vao listbox va text box
            yTuongTextBox.Clear();
            yTuongTextBox.Text = yTuong;
            codeListBox.Items.Clear();
            foreach (string item in code)
            {
                codeListBox.Items.Add(item);
            }
            // nếu là giảm thì sửa lại
            if (!tang)
            {
                codeListBox.Items[0] = "Sắp giảm";
                codeListBox.Items[8] = "            if (a[j] > a[min])";
            }
        }
#endregion

        #region InsertionSort
        public static void InsertionSort(bool tang = true)
        {
            string yTuong = @"Giả sử có một dãy a(0),a(1),...,a(n-1) trong đó i phần tử đầu tiên a(0),a(1),...,a(i-1) đã có thứ tự. Tìm cách chèn phần tử a(i) vào vị trí thích hợp của đoạn đã được sắp để có dãy mới a(0),a(1),...,a(i) trở nên có thứ tự. Vị trí này chính là vị trí giữa hai phần tử a(k-1) và a(k) thỏa a(k-1)<a(i)<a(k) (1<=k<=i)";
            string[] code = ChuyenText(
@"Sắp tăng
                  
void InsertionSort(int a[], int N)
{
    int pos, i;
    int x;
    for(i = 1; i < N; i++)
    {
        x = a[i]; pos = i - 1;
        while((pos >= 0) && (x < a[pos]))
        {
            a[pos + 1] = a[pos];
            pos--;
        }
        a[pos + 1] = x;
    }
}");
            //add vao listbox va text box
            yTuongTextBox.Clear();
            yTuongTextBox.Text = yTuong;
            codeListBox.Items.Clear();
            foreach (string item in code)
            {
                codeListBox.Items.Add(item);
            }
            if (!tang)
            {
                codeListBox.Items[0] = "Sắp giảm";
                codeListBox.Items[9] = "        while((pos >= 0) && (x > a[pos]))";
            }
        }
        #endregion

        #region BubbleSort
        public static void BubbleSort(bool tang = true)
        {
            string yTuong = @"Xuất phát từ cuối dãy,đổi chỗ các cặp phần tử kế cận để đưa phần tử nhỏ hơn hoặc lớn hơn trong cặp phần tử đó về vị trí đúng đầu dãy hiện hành, sau đó sẽ không xét đến nó ở bước tiếp theo,do vậy ở lần xử lý thứ i sẽ có vị trí đầu dãy là i. Lặp lại xử lý trên cho đến khi không còn cặp phần tử nào để xét";
            string[] code = ChuyenText(
@"Sắp tăng                
void BubbleSort(int a[], int N)
{
   int i,j;
   for(i = 0; i < N - 1; i++)
      for(j = N - 1; j > i; j--)
        if(a[j] < a[j - 1])
            Swap(a[j], a[j - 1]);
}");
            yTuongTextBox.Clear();
            yTuongTextBox.Text = yTuong;
            codeListBox.Items.Clear();
            foreach (string item in code)
            {
                codeListBox.Items.Add(item);
            }


            if (!tang)
            {
                codeListBox.Items[0] = "Sắp giảm";
                codeListBox.Items[6] = "       if(a[j] > a[j - 1])";
            }


        }
        #endregion

        #region HeapSort
        public static void HeapSort(bool tang = true)
        {
            string yTuong = @"Khi tìm phần tử nhỏ nhất(lớn nhất) ở bước i, phương pháp SelectionSort không tận dụng được các thông tin đã có được do các phép so sánh ở bước i. Giải thuật HeapSort khắc phục nhược điểm này bằng cách chọn ra được một cấu trúc dữ liệu cho phép tích lũy các thông tin về sự so sánh giá trị các phần tử trong quá trình sắp xếp";
            string[] code = ChuyenText(
@"Sắp tăng    
void HeapSort(int a[], int N)
{
    CreateHeap(a,N - 1);
    int r;
    r = N - 1;
    while(r >= 0)
    {
        Swap(a[0], a[r]);
        r--;
        if(r > 0 )
            Shift(a,0,r);
    }
}

void CreateHeap(int a[], int N)
{
    int l;
    l = N/2 - 1;
    while(l >= 0)
    {
        Shift(a,l,N - 1);
        l--;
    }
}

void Shift(int a[], int l, int r)
{
    int i = l;
    int j = 2*i + 1;
    while(j <= r)
    {
        if(j < r && a[j] < a[j+1]) 
            j++;
        if(a[i] < a[j])
        {
            Swap(a[i], a[j]);
            i = j; 
            j = 2*i + 1;
        }
        else return;
    }
}
");

            yTuongTextBox.Clear();
            yTuongTextBox.Text = yTuong;
            codeListBox.Items.Clear();
            foreach (string item in code)
            {
                codeListBox.Items.Add(item);
            }
        }
        #endregion
    }
}
