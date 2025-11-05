import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

public class ParabolicInterpolation extends JFrame
{
    private final int width = 500;
    private final int height = 500;

    private JPanel panel;
    private JLabel msgLabel;
    private JTextField prompt;
    private JButton calcButton;

    public ParabolicInterpolation()
    {
        setTitle("Parabolic Interpolation Calculator");
        setSize(width, height);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        buildPanel();
        add(panel);
        setVisible(true);
    }

    private void buildPanel()
    {
        msgLabel = new JLabel("Enter a number: ");
        prompt = new JTextField(10);
        calcButton = new JButton("Calculate");
        panel = new JPanel();

        panel.add(msgLabel);
        panel.add(prompt);
        panel.add(calcButton);
    }
    
    public static void main(String[] args)
    {   
        ParabolicInterpolation window = new ParabolicInterpolation();
    }
}