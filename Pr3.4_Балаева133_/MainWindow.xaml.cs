using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pr3._4_Балаева133_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();

            
        }
        class Student
        {
            public string Name { get; set; }


        }
        bool assess = false;
        bool noassess = false;
        string stu;
        string std;



        private void spis_Click(object sender, RoutedEventArgs e)
        {
            student.Items.Add(stu);
            

        }
        private void student_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            assess = true;
            noassess = true;



        }

        private void tb1_TextChanged(object sender, TextChangedEventArgs e)
        {
            stu = tb1.Text;
            


        }
        private void tb2_TextChanged(object sender, TextChangedEventArgs e)
        {
            std = tb2.Text;
        }

        

        private void at_Click(object sender, RoutedEventArgs e)
        {
            if (assess == true)
            {
                
                string sum = (stu + ", " + std);
                var stud = student.SelectedValue;
                var stud2 = assessment.SelectedValue;

                test.Items.Add(sum);
                student.Items.Remove(stud);
                assessment.Items.Remove(stud2);



            }
        }

        private void noat_Click(object sender, RoutedEventArgs e)
        {
            if (noassess == true)
            {
                var st = student.SelectedValue;
                certified.Items.Add(st);
                student.Items.Remove(st);
             }

        }

        private void och_Click(object sender, RoutedEventArgs e)
        {
            assessment.Items.Clear();
            test.Items.Clear();
            certified.Items.Clear();
            student.Items.Clear();

            assess = false;
            noassess = false;
        }

        private void test_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var stud = test.SelectedValue;
            test.Items.Remove(stud);
            student.Items.Add(stud);
        }

        private void certified_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var stud = certified.SelectedValue;
            certified.Items.Remove(stud);
            student.Items.Add(stud);
        }

        private void asses_Click(object sender, RoutedEventArgs e)
        {
            assessment.Items.Add(std);
        }

       
    }
}

