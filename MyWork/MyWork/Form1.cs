namespace MyWork
{
    public partial class Form1 : Form
    {
        public enum Table { Auto = 0, Mark, Engine, Wheel, CarNum }
        private Table curTable;

        public Form1()
        {
            InitializeComponent();
            DataGridViewDbLoad();
        }

        private void DataGridViewDbLoad()
        {
            curTable = Table.Auto;
            using (AutoModelContext db = new AutoModelContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                //Отображаем текущее состояние бд 
                autoDataGridView.DataSource = db.Autos.ToList<Auto>();
                markDataGridView.DataSource = db.Marks.ToList<Mark>();
                engineDataGridView.DataSource = db.Engines.ToList<Engine>();
                wheelDataGridView.DataSource = db.Wheels.ToList<Wheel>();
                carnumDataGridView.DataSource = db.CarNum.ToList<CarNumber>();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (AutoModelContext db = new AutoModelContext())
                    AddNewObject(db, Tb1.Text, Tb2.Text, Tb3.Text, Tb4.Text);
            }
            catch {
                //Отображаем сообщение об ошибке
                MessageBox.Show("Данные введены некоректно");
                return;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Попытка привести к нужному типу
                int id = int.Parse(idTb.Text);

                using (AutoModelContext db = new AutoModelContext())
                {
                    UpdateObject(db, id, Tb1.Text, Tb2.Text, Tb3.Text, Tb4.Text);
                }
            }
            catch 
            {
                //Отображаем сообщение об ошибке
                MessageBox.Show("Данные введены некоректно");
                return;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(idTb.Text);

                using (AutoModelContext db = new AutoModelContext())
                {
                    DeleteObject(db, id);
                }
            }
            catch {
                //Отображаем сообщение об ошибке
                MessageBox.Show("Данные введены некоректно");
                return;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            curTable = (Table)tabControl1.SelectedIndex;

            label1.Enabled = label2.Enabled = label3.Enabled = label4.Enabled = label5.Enabled = true;
            Tb1.Enabled = Tb2.Enabled = Tb3.Enabled = Tb4.Enabled = true;
            Tb1.Text = Tb2.Text = Tb3.Text = Tb4.Text = "";

            switch (curTable) 
            {
                case Table.Auto:
                    label2.Text = "Модель:";
                    label3.Text = "Марка:";
                    label4.Text = "Цена:";
                    label5.Text = "Количесво:";
                    break;
                case Table.Mark:
                    label2.Text = "Название:";
                    label3.Text = "Страна:";
                    label4.Text = "Описание:";
                    label5.Text = String.Empty;
                    Tb4.Enabled = false;
                    break;
                case Table.Engine:
                    label2.Text = "Название:";
                    label3.Text = "Компания:";
                    label4.Text = "Макс. Мощность:";
                    label5.Text = String.Empty;
                    Tb4.Enabled = false;
                    break;
                case Table.Wheel:
                    label2.Text = "Название:";
                    label3.Text = "Компания:";
                    label4.Text = String.Empty;
                    label5.Text = String.Empty;
                    Tb3.Enabled = Tb4.Enabled = false;
                    break;
                case Table.CarNum:
                    label2.Text = "Номер:";
                    label3.Text = "Регион:";
                    label4.Text = String.Empty;
                    label5.Text = String.Empty;
                    Tb3.Enabled = Tb4.Enabled = false;
                    break;
            }
        }

        private void UpdateObject(AutoModelContext db, int id, string tb1, string tb2, string tb3, string tb4) 
        {
            try
            {
                switch (curTable)
                {
                    case Table.Auto:
                        int cost = int.Parse(tb3);
                        int amount = int.Parse(tb4);

                        Auto autoToUpdate = new Auto { Id = id ,Model = tb1, Mark = tb2, Cost = cost, Amount = amount };

                        db.Autos.Update(autoToUpdate);
                        db.SaveChanges();

                        autoDataGridView.DataSource = db.Autos.ToList<Auto>();
                        break;
                    case Table.Mark:
                        Mark markToUpdate = new Mark { Id = id, Name = tb1, Country = tb2, Description = tb3 };

                        db.Marks.Update(markToUpdate);
                        db.SaveChanges();

                        markDataGridView.DataSource = db.Marks.ToList<Mark>();
                        break;
                    case Table.Engine:
                        int maxSpeed = int.Parse(tb3);

                        Engine engineToUpdate = new Engine { Id = id, Name = tb1, Company = tb2, MaxSpeed = maxSpeed };

                        db.Engines.Update(engineToUpdate);
                        db.SaveChanges();

                        engineDataGridView.DataSource = db.Engines.ToList<Engine>();
                        break;
                    case Table.Wheel:

                        Wheel wheelToUpdate = new Wheel { Id = id, Name = tb1, Company = tb2};

                        db.Wheels.Update(wheelToUpdate);
                        db.SaveChanges();

                        wheelDataGridView.DataSource = db.Wheels.ToList<Wheel>();
                        break;
                    case Table.CarNum:
                        int regNum = int.Parse(tb2);

                        CarNumber carnumToUpdate = new CarNumber { Id = id, Number = tb1, RegNum = regNum };

                        db.CarNum.Update(carnumToUpdate);
                        db.SaveChanges();

                        carnumDataGridView.DataSource = db.CarNum.ToList<CarNumber>();
                        break;
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Некорректно введены данные");
            }
            catch
            {
                MessageBox.Show("Невозможно обновить данные, которых еще нет в БД");
            }
        }

        private void AddNewObject(AutoModelContext db, string tb1, string tb2, string tb3, string tb4) 
        {
            switch (curTable)
            {
                case Table.Auto:
                    int cost = int.Parse(tb3);
                    int amount = int.Parse(tb4);

                    db.Autos.Add(new Auto { Model = tb1, Mark = tb2, Cost = cost, Amount = amount});
                    db.SaveChanges();

                    autoDataGridView.DataSource = db.Autos.ToList<Auto>();
                    break;
                case Table.Mark:

                    db.Marks.Add(new Mark { Name = tb1, Country = tb2, Description = tb3});
                    db.SaveChanges();

                    markDataGridView.DataSource = db.Marks.ToList<Mark>();
                    break;
                case Table.Engine:
                    int maxSpeed = int.Parse(tb3);

                    db.Engines.Add(new Engine { Name = tb1, Company = tb2, MaxSpeed = maxSpeed });
                    db.SaveChanges();

                    engineDataGridView.DataSource = db.Engines.ToList<Engine>();
                    break;
                case Table.Wheel:

                    db.Wheels.Add(new Wheel { Name = tb1, Company = tb2});
                    db.SaveChanges();

                    wheelDataGridView.DataSource = db.Wheels.ToList<Wheel>();
                    break;
                case Table.CarNum:
                    int regNum = int.Parse(tb2);

                    CarNumber carnumToAdd = new CarNumber { Number = tb1, RegNum = regNum };

                    db.CarNum.Add(carnumToAdd);
                    db.SaveChanges();

                    carnumDataGridView.DataSource = db.CarNum.ToList<CarNumber>();
                    break;
            }
        }

        private void DeleteObject(AutoModelContext db, int id)
        {
            switch (curTable)
            {
                case Table.Auto:
                    Auto? autoToRemove = db.Autos.FirstOrDefault<Auto?>(auto => auto.Id == id);
                    if (autoToRemove != null)
                    {
                        db.Autos.Remove(autoToRemove);
                        db.SaveChanges();

                        autoDataGridView.DataSource = db.Autos.ToList<Auto>();
                    }
                    else
                        MessageBox.Show("Нельзя удалить данные, которых нет в БД");
                    break;
                case Table.Mark:
                    Mark? markToRemove = db.Marks.FirstOrDefault<Mark?>(mark => mark.Id == id);
                    if (markToRemove != null)
                    {
                        db.Marks.Remove(markToRemove);
                        db.SaveChanges();

                        markDataGridView.DataSource = db.Marks.ToList<Mark>();
                    }
                    else
                        MessageBox.Show("Нельзя удалить данные, которых нет в БД");
                    break;
                case Table.Engine:
                    Engine? engineToRemove = db.Engines.FirstOrDefault<Engine?>(engine => engine.Id == id);
                    if (engineToRemove != null)
                    {
                        db.Engines.Remove(engineToRemove);
                        db.SaveChanges();

                        engineDataGridView.DataSource = db.Engines.ToList<Engine>();
                    }
                    else
                        MessageBox.Show("Нельзя удалить данные, которых нет в БД");
                    break;
                case Table.Wheel:
                    Wheel? wheelToRemove = db.Wheels.FirstOrDefault<Wheel?>(wheel => wheel.Id == id);
                    if (wheelToRemove != null)
                    {
                        db.Wheels.Remove(wheelToRemove);
                        db.SaveChanges();

                        wheelDataGridView.DataSource = db.Wheels.ToList<Wheel>();
                    }
                    else
                        MessageBox.Show("Нельзя удалить данные, которых нет в БД");
                    break;
                case Table.CarNum:
                    CarNumber? carnumToRemove = db.CarNum.FirstOrDefault<CarNumber?>(num => num.Id == id);
                    if (carnumToRemove != null)
                    {
                        db.CarNum.Remove(carnumToRemove);
                        db.SaveChanges();

                        carnumDataGridView.DataSource = db.CarNum.ToList<CarNumber>();
                    }
                    else
                        MessageBox.Show("Нельзя удалить данные, которых нет в БД");
                    break;
            }
        }

        private void autoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Auto autoData = ((List<Auto>)autoDataGridView.DataSource)[e.RowIndex];
                idTb.Text = autoData.Id.ToString();
                Tb1.Text = autoData.Model;
                Tb2.Text = autoData.Mark;
                Tb3.Text = autoData.Cost.ToString();
                Tb4.Text = autoData.Amount.ToString();
            }
            catch 
            {
                MessageBox.Show("Неудачная попытка скопировать данные в форму!\n" +
                                "Чтобы скопировать данные в форму, нажмите дважды ячейку с данными.");
            }
        }

        private void markDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Mark markData = ((List<Mark>)markDataGridView.DataSource)[e.RowIndex];
                idTb.Text = markData.Id.ToString();
                Tb1.Text = markData.Name;
                Tb2.Text = markData.Country;
                Tb3.Text = markData.Description;
            }
            catch
            {
                MessageBox.Show("Неудачная попытка скопировать данные в форму!\n" +
                                "Чтобы скопировать данные в форму, нажмите дважды ячейку с данными.");
            }
        }

        private void engineDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Engine engineData = ((List<Engine>)engineDataGridView.DataSource)[e.RowIndex];
                idTb.Text = engineData.Id.ToString();
                Tb1.Text = engineData.Name;
                Tb2.Text = engineData.Company;
                Tb3.Text = engineData.MaxSpeed.ToString();
            }
            catch
            {
                MessageBox.Show("Неудачная попытка скопировать данные в форму!\n" +
                                "Чтобы скопировать данные в форму, нажмите дважды ячейку с данными.");
            }
        }

        private void wheelDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Wheel wheelData = ((List<Wheel>)wheelDataGridView.DataSource)[e.RowIndex];
                idTb.Text = wheelData.Id.ToString();
                Tb1.Text = wheelData.Name;
                Tb2.Text = wheelData.Company;
            }
            catch
            {
                MessageBox.Show("Неудачная попытка скопировать данные в форму!\n" +
                                "Чтобы скопировать данные в форму, нажмите дважды ячейку с данными.");
            }
        }

        private void carnumDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CarNumber carnumData = ((List<CarNumber>)carnumDataGridView.DataSource)[e.RowIndex];
                idTb.Text = carnumData.Id.ToString();
                Tb1.Text = carnumData.Number;
                Tb2.Text = carnumData.RegNum.ToString();
            }
            catch
            {
                MessageBox.Show("Неудачная попытка скопировать данные в форму!\n" +
                                "Чтобы скопировать данные в форму, нажмите дважды ячейку с данными.");
            }
        }
    }
}