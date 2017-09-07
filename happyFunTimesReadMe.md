# This is a mark down file type

>notes by Justin Haimila

The line above is equivilent to an <h1> This is a mark down file type</h1> HTML Mark up
The Idea of Markdown files is to make it easier to write text that you want too have some sort of richness to it, but don't want 
to get hung up on details of markup (HTML) or having to resort to more binary representation such as in MS word

Markdown can produce lists, just like this:
- A list Item can start with either a dash or an assterix
	- It's  a good idea to be consistent 
	- This lin, and the one above are indented in the list
- Unordered lists are easy to do in MD
-Besides unordered lists. you can do ordered lists/ for an ordered list use the number 1 followed by a dot

## Other Examples

the line above is equivilent to an <h2> Other Examples </h2> you can use up to 6 symbols

1. Learn about the different stylings for MD. Specifically, how to do ... 
	1. Headings
	1. lists both UO and O
	1. code snippets like '<h1> This </h1>'
	1. code blocks (multiple lines of code)
	1. **Bold** *Italic*
	1. tables
	1. Hyperlinks www.google.ca
	1. Images
	1. Other interesting things
1. Answer the question, What is thedifference between **GitHub flavored MD**(GFM) and regular Markdown?
1. find out how to do a checkbox in a list item using GFM

## Code Blocks 

You can do code blocks in md, and even have it hightlighted in the right colors for the appropriate kind of code. For example, here's some HTML.

``` here os am example of C# code

``` csharp
	public class Greeter
	
	private string Greeting = "Hello World";
	private string Goodbye;
	
	public Greeter (string greeting, string goodbye)
	{
		Greeting = greeting;
		Goodbye = goodbye;
		
	}
	
	public string SayHello()
	{
		return Greeting;
	}