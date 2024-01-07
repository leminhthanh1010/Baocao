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
        #region InterchangeSort
        public static void InterchangeSort(bool tang = true)
        {
            string yTuong = @"Xuất phát từ đầu dãy,tìm tất cả các cặp nghịch thế chứa phần tử này, triệt tiêu chúng bằng cách đổi phần tử này với phần tử tương ứng trong cặp nghịch thế .Lặp lại xử lý trên với các phần tử tiếp theo";
            string[] code = ChuyenText(
@"Sắp tăng
void InterchangeSort( int a[], int N)
{
    int i, j;
    for(i = 0; i < N - 1; i++)
        for(j = i + 1; j < N; j++)
            if( a[j] < a[i] )
                Swap( a[i], a[j]);
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
                codeListBox.Items[6] = "            if( a[j] > a[i] )";
            }

        }
        #endregion

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
    }
}
