using DesafioPOO.Models;

Smartphone nokia = new Nokia("123476450", "C3", "43528945923458237458", 4);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Spotify");

Smartphone iPhone = new Iphone("52245252525", "13", "2528492849283490284", 4);
iPhone.Ligar();
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Whatsapp");
iPhone.Numero = "542376890";