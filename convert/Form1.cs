using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack_DS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnConvertToPostfix_Click(object sender, EventArgs e)
        {
            string infix = txtInfix.Text.Trim();
            string postfix = InfixToPostfix(infix);
            MessageBox.Show("Postfix Expression: " + postfix);
        }

        private void btnConvertToInfix_Click(object sender, EventArgs e)
        {
            string postfix = txtPostfix.Text.Trim();
            string infix = PostfixToInfix(postfix);
            MessageBox.Show("Infix Expression: " + infix);
        }

        private int GetPrecedence(char op)
        {
            switch (op)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '^':
                    return 3;
                default:
                    return 0;
            }
        }

        private List<string> Tokenize(string input)
        {
            var tokens = new List<string>();
            StringBuilder token = new StringBuilder();

            foreach (char ch in input)
            {
                if (char.IsWhiteSpace(ch))
                {
                    continue;
                }

                if (char.IsLetterOrDigit(ch) || ch == '.')
                {
                    token.Append(ch);
                }
                else
                {
                    if (token.Length > 0)
                    {
                        tokens.Add(token.ToString());
                        token.Clear();
                    }

                    tokens.Add(ch.ToString());
                }
            }

            if (token.Length > 0)
            {
                tokens.Add(token.ToString());
            }

            return tokens;
        }

        private string InfixToPostfix(string infix)
        {
            StringBuilder output = new StringBuilder();
            Stack<char> stack = new Stack<char>();
            var tokens = Tokenize(infix);

            foreach (var token in tokens)
            {
                if (char.TryParse(token, out char c) && char.IsLetterOrDigit(c))
                {
                    output.Append(token + " ");
                }
                else if (token == "(")
                {
                    stack.Push('(');
                }
                else if (token == ")")
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        output.Append(stack.Pop() + " ");
                    }
                    stack.Pop(); 
                }
                else 
                {
                    while (stack.Count > 0 && GetPrecedence(stack.Peek()) >= GetPrecedence(c))
                    {
                        output.Append(stack.Pop() + " ");
                    }
                    stack.Push(c);
                }
            }

            while (stack.Count > 0)
            {
                output.Append(stack.Pop() + " ");
            }

            return output.ToString().Trim();
        }

        public string PostfixToInfix(string postfix)
        {
            Stack<string> stack = new Stack<string>();
            var tokens = postfix.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var token in tokens)
            {
                if (char.IsLetterOrDigit(token[0]))
                {
                    stack.Push(token);
                }
                else  
                {
                    if (stack.Count < 2)
                    {
                        Console.WriteLine("Error: Invalid Postfix Expression.");
                        return string.Empty; 
                    }
                    var op2 = stack.Pop();
                    var op1 = stack.Pop();

                    var expression = $"({op1} {token} {op2})";
                    stack.Push(expression); 
                }
            }
            if (stack.Count != 1)
            {
                Console.WriteLine("Error: Invalid Postfix Expression.");
                return string.Empty;
            }
            return stack.Pop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
