using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace DungeonHelper
{
    public partial class ucBattle : UserControl
    {
        public static ucBattle _instance;
        public static ucBattle Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucBattle();
                return _instance;
            }
        }

        Image p = Image.FromFile("tile_1.png");
        Bitmap image1;
        //массив существ
        List<Creatures> listCreatures = new List<Creatures>();
        //массив иконок существ
        List<PictureBox> creatures_icon;
        GroupBox[] gb = new GroupBox[12];
        Label[] name_creature = new Label[12];
        TextBox[] init = new TextBox[12];
        PictureBox[] picture_creature = new PictureBox[12];
        TextBox[] health = new TextBox[12];
        ProgressBar[] progressBar = new ProgressBar[12];
        public ucBattle()
        {
            InitializeComponent();
            creatures_icon = new List<PictureBox>();
            CreateMap(20, 20);
            LoadTiles();
            CreateArrays();
        }
        private void CreateArrays()
        {
            gb[0] = groupBox1;
            gb[1] = groupBox2;
            gb[2] = groupBox3;
            gb[3] = groupBox4;
            gb[4] = groupBox5;
            gb[5] = groupBox6;
            gb[6] = groupBox7;
            gb[7] = groupBox8;
            gb[8] = groupBox9;
            gb[9] = groupBox10;
            gb[10] = groupBox11;
            gb[11] = groupBox12;
            health[0] = textBox_Health1;
            health[1] = textBox_Health2;
            health[2] = textBox_Health3;
            health[3] = textBox_Health4;
            health[4] = textBox_Health5;
            health[5] = textBox_Health6;
            health[6] = textBox_Health7;
            health[7] = textBox_Health8;
            health[8] = textBox_Health9;
            health[9] = textBox_Health10;
            health[10] = textBox_Health11;
            health[11] = textBox_Health12;
            init[0] = textBox_init1;
            init[1] = textBox_init2;
            init[2] = textBox_init3;
            init[3] = textBox_init4;
            init[4] = textBox_init5;
            init[5] = textBox_init6;
            init[6] = textBox_init7;
            init[7] = textBox_init8;
            init[8] = textBox_init9;
            init[9] = textBox_init10;
            init[10] = textBox_init11;
            init[11] = textBox_init12;
            picture_creature[0] = pb_Creature1;
            picture_creature[1] = pb_Creature2;
            picture_creature[2] = pb_Creature3;
            picture_creature[3] = pb_Creature4;
            picture_creature[4] = pb_Creature5;
            picture_creature[5] = pb_Creature6;
            picture_creature[6] = pb_Creature7;
            picture_creature[7] = pb_Creature8;
            picture_creature[8] = pb_Creature9;
            picture_creature[9] = pb_Creature10;
            picture_creature[10] = pb_Creature11;
            picture_creature[11] = pb_Creature12;
            name_creature[0] = label1_name;
            name_creature[1] = label2_name;
            name_creature[2] = label3_name;
            name_creature[3] = label4_name;
            name_creature[4] = label5_name;
            name_creature[5] = label6_name;
            name_creature[6] = label7_name;
            name_creature[7] = label8_name;
            name_creature[8] = label9_name;
            name_creature[9] = label10_name;
            name_creature[10] = label11_name;
            name_creature[11] = label12_name;
            progressBar[0] = progressBar1;
            progressBar[1] = progressBar2;
            progressBar[2] = progressBar3;
            progressBar[3] = progressBar4;
            progressBar[4] = progressBar5;
            progressBar[5] = progressBar6;
            progressBar[6] = progressBar7;
            progressBar[7] = progressBar8;
            progressBar[8] = progressBar9;
            progressBar[9] = progressBar10;
            progressBar[10] = progressBar11;
            progressBar[11] = progressBar12;
        }
        //массив для хранения тайлов
        PictureBox[,] pictureBox;
        //загрузка тайлов
        private void LoadTiles()
        {
            pictureBox = new PictureBox[5, 4];
            int x = 0;
            int y = 38;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    pictureBox[i, j] = new PictureBox();
                    pictureBox[i, j].Location = new System.Drawing.Point(900 + x, y);
                    pictureBox[i, j].Size = new System.Drawing.Size(32, 32);
                    pictureBox[i, j].Name = "tile" + i.ToString();
                    pictureBox[i, j].Image = Image.FromFile("tile_" + (i * 4 + j) + ".png");
                    pictureBox[i, j].Click += PictureBox_Click;
                    Controls.Add(pictureBox[i, j]);
                    x += 32;
                }
                y += 32;
                x = 0;
            }
        }
        //создание карты с тайлами травы
        public void CreateMap(int x, int y)
        {
            Image[,] img = new Image[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    img[i, j] = Image.FromFile("tile_1.png");
                }
            }
            image1 = CombineImages(img, x, y);
            pictureBox6.Image = image1;
        }
        //смена тайла
        private Bitmap ChangeImgages(int x, int y, Bitmap bmap, Image img)
        {
            if (!fight)
            {
                using (Graphics gr = Graphics.FromImage(bmap))
                {
                    int w = x;
                    int h = y;
                    w /= 43;
                    int d1 = w;
                    w *= 43;

                    h /= 43;
                    int d2 = h;
                    h *= 43;
                    gr.DrawImage(img, w + d1, h + d2);
                }
            }
            return bmap;
        }
        //создание Bitmap картинки из тайлов
        private Bitmap CombineImages(Image[,] images, int x, int y)
        {
            int width = x * 44;
            int height = y * 44;
            pictureBox6.Width = width;
            pictureBox6.Height = height;
            // склеиваем картинку
            Bitmap result = new Bitmap(width, height);
            using (Graphics gr = Graphics.FromImage(result))
            {
                // фон будет белым
                gr.FillRectangle(Brushes.Black, new Rectangle(0, 0, width, height));

                int c = 0;
                int b = 0;
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        gr.DrawImage(images[i, j], new Point(c, b));
                        b += 44;
                    }
                    b = 0;
                    c += 44;
                }
            }
            return result;
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            p = pb.Image;
        }
        bool isClicked = false;
        //смена тайлов
        private void PictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox6.Image = ChangeImgages(e.X, e.Y, image1, p);
            isClicked = true;
        }
        //смена тайлов
        private void PictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            if (isClicked)
            {
                pictureBox6.Image = ChangeImgages(e.X, e.Y, image1, p);
            }
        }
        private void PictureBox6_MouseUp(object sender, MouseEventArgs e)
        {
            isClicked = false;
        }
        //добавление существа
        public void AddCreature(string name)
        {
            gb[listCreatures.Count].Visible = true;
            Random rand = new Random();
            //генерирование инициативы
            init[listCreatures.Count].Text = rand.Next(1, 20).ToString();
            picture_creature[listCreatures.Count].Image = Image.FromFile(name + ".jpg");
            name_creature[listCreatures.Count].Text = name;
            //создание объекта типа Creatures из типа string
            Type a = Type.GetType("DungeonHelper." + name);
            System.Reflection.ConstructorInfo ci = a.GetConstructor(new Type[] { });
            object Obj = ci.Invoke(new object[] { });
            listCreatures.Add((Creatures)Obj);
            health[listCreatures.Count - 1].Text = listCreatures[listCreatures.Count - 1].Health.ToString();
            progressBar[listCreatures.Count - 1].Maximum = Convert.ToInt32(health[listCreatures.Count - 1].Text);
            PictureBox pb = new PictureBox();
            if (creatures_icon.Count == 0)
                pb.Location = new Point(5, 54);
            //ограничение переноса существ за карту и переноса друг на друга
            else
            {
                bool isFree = true;
                for (int k = 54; k < 900; k += 44)
                {
                    for (int i = 5; i < 860; i += 44)
                    {
                        isFree = true;
                        for (int j = 0; j < creatures_icon.Count; j++)
                        {
                            if (i == creatures_icon[j].Location.X && k==creatures_icon[j].Location.Y)
                            {
                                isFree = false;
                            }
                        }
                        if (isFree)
                        {
                            pb.Location = new Point(i, k);
                            break;
                        }
                    }
                    if (isFree)
                    {
                        break;
                    }
                }
            }
            pb.Size = new Size(32, 32);
            pb.Name = "pbCreature" + listCreatures.Count;
            pb.Image = Image.FromFile(name + ".jpg");
            pb.MouseDown += PictureBox3_MouseDown;
            pb.MouseUp += PictureBox3_MouseUp;
            pb.MouseMove += PictureBox3_MouseMove;
            //закругление картинки
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, 30, 30);
            Region rgn = new Region(path);
            pb.Region = rgn;
            Controls.Add(pb);
            pb.BringToFront();
            creatures_icon.Add(pb);

        }
    
        bool iMove = false;
        int old_x; //старое расположение иконки по x
        int old_y; //старое расположение иконки по y
        bool fight = false; //режим сражения
        bool attack = false; //режим атаки
        bool spell = false; //режим атаки заклинанием
        private void PictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            //режим атаки
            if (attack)
            {
                PictureBox pb = (PictureBox)sender;
                int i;
                for (i = 0; i < creatures_icon.Count; i++)
                {
                    if (pb == creatures_icon[i])
                        break;
                }
                //атака
                int hit = listCreatures[cur].Attack();
                textBox_hit.Text = listCreatures[cur].Name + " атакует: " + hit.ToString();
                //проверка класса доспеха
                int isHit = listCreatures[i].CheckArmor(hit);
                //если попал
                if (isHit == 1)
                {
                    //нанесение урона
                    int damage = listCreatures[cur].GiveDamage();
                    textBox_hit.Text +="\r\n"+ listCreatures[cur].Name + " наносит урон: " + damage.ToString();
                    //получение урона
                    listCreatures[i].TakeDamege(damage);
                    progressBar[i].Value = listCreatures[i].Health;
                    health[i].Text = listCreatures[i].Health.ToString();
                    if(listCreatures[i].Health == 0)
                    {
                       
                        creatures_icon[i].Visible = false;
                    }
                }
                else
                {
                    textBox_hit.Text += ". Промах!";
                }
                listCreatures[cur].Count_attack--;
                if(listCreatures[cur].Count_attack == 0)
                {
                    btn_attack.Enabled = false;
                }
                attack = false;
            }
            //режим атаки заклинанием
            else if (spell)
            {
                PictureBox pb = (PictureBox)sender;
                int i;
                for (i = 0; i < creatures_icon.Count; i++)
                {
                    if (pb == creatures_icon[i])
                        break;
                }
                //получение характеристики
                int charact = listCreatures[cur].SpellCharact();
                //получение сложности
                int diff = listCreatures[cur].SpellDiff();
                //спасбросок ъарактеристики
                int isHit = listCreatures[i].CheckСharacteristic(charact, diff);
                //если попал
                if(isHit == 1)
                {
                    //нанесение урона
                    int damage = listCreatures[cur].SpellDamage();
                    //получение урона
                    listCreatures[i].TakeDamege(damage);
                    textBox_hit.Text = "Противник не проходит спас-бросок";
                    textBox_hit.Text += "\r\n" + listCreatures[cur].SpellName() + " наносит урон: " + damage;
                    progressBar[i].Value = listCreatures[i].Health;
                    health[i].Text = listCreatures[i].Health.ToString();
                    if (listCreatures[i].Health == 0)
                    {

                        creatures_icon[i].Visible = false;
                    }
                }
                else
                {
                    textBox_hit.Text = "Противник проходит спас-бросок";
                }
                button_spell.Enabled = false;
                spell = false;
            }
            //режим передвижения
            else
            {
                PictureBox pb = (PictureBox)sender;
                bool n = true;
                if (pb.Location.X >= 860 || pb.Location.Y >= 900 || pb.Location.Y <= 50)
                {
                    pb.Location = new Point(old_x, old_y);
                    n = false;
                }
                double x = RoundToIncrement(pb.Location.X, 44);
                double y = RoundToIncrement(pb.Location.Y, 44);
                pb.Location = new Point((int)((x + 5)), (int)((y + 10)));
                bool isPlaced = false;
                if (n)
                {
                    for (int i = 0; i < creatures_icon.Count; i++)
                    {
                        if (pb.Location == creatures_icon[i].Location)
                        {
                            if (pb != creatures_icon[i])
                            {
                                int movePoint = Convert.ToInt32(textBox_move.Text);
                                movePoint += 5;
                                textBox_move.Text = movePoint.ToString();
                                pb.Location = new Point(old_x, old_y);
                                isPlaced = true;
                            }
                        }
                    }
                }
                if (fight)
                {
                    x += 5;
                    y += 10;
                    if (Math.Abs(old_x - x) > 50 || Math.Abs(old_y - y) > 50)
                    {
                        pb.Location = new Point(old_x, old_y);
                        if (isPlaced && n)
                        {
                            int movePoint = Convert.ToInt32(textBox_move.Text);
                            movePoint -= 5;
                            textBox_move.Text = movePoint.ToString();
                        }
                    }
                    else
                    {
                        if (n)
                        {
                            int movePoint = Convert.ToInt32(textBox_move.Text);
                            movePoint -= 5;
                            textBox_move.Text = movePoint.ToString();
                            if (movePoint == 0)
                            {
                                pb.Enabled = false;
                            }
                        }
                    }
                }
                iMove = false;
            }
        }
        Point dot; //старое расположение иконки
        //перенос иконки
        private void PictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (iMove && !attack && !spell)
            {
                PictureBox pb = (PictureBox)sender;
                pb.Top += e.Y - dot.Y;
                pb.Left += e.X - dot.X;
            }
        }
        private void PictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            if (!attack && !spell)
            {
                PictureBox pb = (PictureBox)sender;
                iMove = true;
                dot = e.Location;
                old_x = pb.Location.X;
                old_y = pb.Location.Y;
            }
        }
        //округление координаты для вставки иконки в центр тайла
        double RoundToIncrement(double x, double m)
        {
            return Math.Round(x / m) * m;
        }
        bool b = false;
        int ChangeValueProgressBar(int x, ProgressBar pb)
        {
            return pb.Maximum * x / pb.Width;
        }
        //изменения хп существа
        private void ProgressBar1_MouseDown(object sender, MouseEventArgs e)
        {
            ProgressBar pb = (ProgressBar)sender;
            int k = 0;
            for(int i = 0; i < 12; i++)
            {
                if(pb == progressBar[i])
                {
                    k = i;
                    break;
                }
            }
            b = true;
            pb.Value = ChangeValueProgressBar(e.X, pb);
            health[k].Text = pb.Value.ToString();
            listCreatures[k].Health = pb.Value;
        }
        //изменение хп существа
        private void ProgressBar1_MouseMove(object sender, MouseEventArgs e)
        {
            if (b)
            {
                ProgressBar pb = (ProgressBar)sender;
                int k = 0;
                for (int i = 0; i < 12; i++)
                {
                    if (pb == progressBar[i])
                    {
                        k = i;
                        break;
                    }
                }
                int value = ChangeValueProgressBar(e.X,pb);
                if (value >= pb.Minimum && value <= pb.Maximum)
                {
                    pb.Value = ChangeValueProgressBar(e.X,pb);
                    health[k].Text = pb.Value.ToString();
                    listCreatures[k].Health = pb.Value;
                }
            }
        }

        private void ProgressBar1_MouseUp(object sender, MouseEventArgs e)
        {
            b = false;
        }
        //изменение хп существа
        private void TextBox_Health_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int k = 0;
            for (int i = 0; i < 12; i++)
            {
                if (tb == health[i])
                {
                    k = i;
                    break;
                }
            }
            if (tb.Text != "")
                if(Convert.ToInt32(tb.Text) >= progressBar[k].Minimum && Convert.ToInt32(tb.Text) <= progressBar[k].Maximum)
                    progressBar[k].Value = Convert.ToInt32(tb.Text);
            listCreatures[k].Health = Convert.ToInt32(tb.Text);
        }
        int cur; //текущий индекс существа
        //начать бой
        private void Button4_Click(object sender, EventArgs e)
        {
            //завершение боя
            if (button4.Text == "Завершить бой")
            {
                label3.Visible = false;
                textBox_move.Visible = false;
                button_over.Visible = false;
                btn_attack.Visible = false;
                button_spell.Visible = false;
                textBox_hit.Visible = false;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        pictureBox[i, j].Visible = true;
                    }
                }
                for (int i = 0; i < listCreatures.Count; i++)
                {
                    gb[i].Visible = false;
                    creatures_icon[i].Visible = false;
                }
                listCreatures.Clear();
                creatures_icon.Clear();
                CreateArrays();
                button4.Text = "Начать бой";
                fight = false;
            }
            //начало боя
            else
            {
                if (listCreatures.Count != 0)
                {

                    label3.Visible = true;
                    textBox_move.Visible = true;
                    button_over.Visible = true;
                    btn_attack.Visible = true;
                    button_spell.Visible = true;
                    textBox_hit.Visible = true;
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            pictureBox[i, j].Visible = false;
                        }
                    }
                    int[] initiative = new int[listCreatures.Count];

                    for (int i = 0; i < listCreatures.Count; i++)
                    {
                        initiative[i] = Convert.ToInt32(init[i].Text);
                    }
                    //сортировка существ в зависисмости от инициативы
                    for (int i = 0; i < initiative.Length - 1; i++)
                    {
                        for (int j = i + 1; j < initiative.Length; j++)
                        {
                            if (initiative[i] > initiative[j])
                            {
                                int temp = initiative[i];
                                initiative[i] = initiative[j];
                                initiative[j] = temp;
                                Creatures c = listCreatures[i];
                                listCreatures[i] = listCreatures[j];
                                listCreatures[j] = c;
                                PictureBox p = creatures_icon[i];
                                creatures_icon[i] = creatures_icon[j];
                                creatures_icon[j] = p;
                                GroupBox g = gb[i];
                                gb[i] = gb[j];
                                gb[j] = g;
                                ProgressBar pb = progressBar[i];
                                progressBar[i] = progressBar[j];
                                progressBar[j] = pb;
                                TextBox t = health[i];
                                health[i] = health[j];
                                health[j] = t;
                            }
                        }
                    }
                    btn_attack.Visible = true;
                    for (int i = 0; i < listCreatures.Count; i++)
                    {
                        init[i].Enabled = false;
                        creatures_icon[i].Enabled = false;
                    }
                    creatures_icon[0].Enabled = true;
                    gb[0].BackColor = Color.Bisque;
                    textBox_move.Text = listCreatures[0].Speed.ToString();
                    fight = true;
                    cur = 0;
                    button4.Text = "Завершить бой";
                }
            }
        }
        // переход в режим атаки
        private void Btn_attack_Click(object sender, EventArgs e)
        {
            spell = false;
            attack = true;
            bool isEmpty = true;
            int x1 = creatures_icon[cur].Location.X;
            int y1 = creatures_icon[cur].Location.Y;
            creatures_icon[cur].Enabled = false;
            for (int i = 0; i < listCreatures.Count; i++)
            {
                int x2 = creatures_icon[i].Location.X;
                int y2 = creatures_icon[i].Location.Y;
                if (Math.Abs(x1-x2) < 50 && Math.Abs(y1-y2) < 50 && creatures_icon[cur] != creatures_icon[i])
                {
                    creatures_icon[i].Enabled = true;
                    isEmpty = false;
                }
            }
            //выход если рядом никаго
            if (isEmpty)
            {
                attack = false;
                creatures_icon[cur].Enabled = true;
            }
        }
        //переход в режим атаки заклинанием
        private void Button_spell_Click(object sender, EventArgs e)
        {
            attack = false;
            spell = true;
            for(int i = 0; i < listCreatures.Count; i++)
            {
                creatures_icon[i].Enabled = true;
            }
            creatures_icon[cur].Enabled = false;
        }
        //передача хода
        private void Button_over_Click(object sender, EventArgs e)
        {
            attack = false;
            spell = false;
            creatures_icon[cur].Enabled = false;
            gb[cur].BackColor = Color.White;
            creatures_icon[cur].Image = Image.FromFile(listCreatures[cur].ToString().Substring(14) + ".jpg");
            creatures_icon[cur].Size = new Size(32, 32);
            for(int i = 0; i < listCreatures.Count; i++)
            {
                cur++;
                if (cur == listCreatures.Count)
                    cur = 0;
                if (listCreatures[cur].Health != 0)
                {
                    break;
                }
            }
            creatures_icon[cur].Enabled = true;
            gb[cur].BackColor = Color.Bisque;
            textBox_move.Text = listCreatures[cur].Speed.ToString();
            btn_attack.Enabled = true;
            button_spell.Enabled = true;
        }
        //открытие формы
        private void Button1_Click(object sender, EventArgs e)
        {
            CreatePerson form = new CreatePerson(this);
            form.Show();

        }
        //добавление персонажа
        public void AddPerson(string name, int armor, int hp, int speed, int strength, int agility, int constitution, int intelligence, int wisdom, int charisma, int attack_bonus, int count_attack, Weapons weapon, Magic magic)
        {
            Person p = new Person(name, armor, hp, speed, strength, agility, constitution, intelligence,wisdom, charisma, attack_bonus, count_attack, weapon,magic);
            gb[listCreatures.Count].Visible = true;
            Random rand = new Random();
            init[listCreatures.Count].Text = rand.Next(1, 20).ToString();
            picture_creature[listCreatures.Count].Image = Image.FromFile("Person.jpg");
            name_creature[listCreatures.Count].Text = name;
            listCreatures.Add(p);
            health[listCreatures.Count - 1].Text = listCreatures[listCreatures.Count - 1].Health.ToString();
            progressBar[listCreatures.Count - 1].Maximum = Convert.ToInt32(health[listCreatures.Count - 1].Text);
            PictureBox pb = new PictureBox();
            if (creatures_icon.Count == 0)
                pb.Location = new Point(5, 54);
            else
            {
                bool isFree = true;
                for (int k = 54; k < 900; k += 44)
                {
                    for (int i = 5; i < 860; i += 44)
                    {
                        isFree = true;
                        for (int j = 0; j < creatures_icon.Count; j++)
                        {
                            if (i == creatures_icon[j].Location.X && k == creatures_icon[j].Location.Y)
                            {
                                isFree = false;
                            }
                        }
                        if (isFree)
                        {
                            pb.Location = new Point(i, k);
                            break;
                        }
                    }
                    if (isFree)
                    {
                        break;
                    }
                }
            }
            pb.Size = new Size(32, 32);
            pb.Name = "pbCreature" + listCreatures.Count;
            pb.Image = Image.FromFile("Person.jpg");
            pb.MouseDown += PictureBox3_MouseDown;
            pb.MouseUp += PictureBox3_MouseUp;
            pb.MouseMove += PictureBox3_MouseMove;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, 30, 30);
            Region rgn = new Region(path);
            pb.Region = rgn;
            Controls.Add(pb);
            pb.BringToFront();
            creatures_icon.Add(pb);
        }
    }
}
