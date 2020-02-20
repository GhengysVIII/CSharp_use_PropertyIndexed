namespace use_OperatorMethods {
    internal class Carte {

        public string Name { get; set; }
        public Carte(string Name) {
            this.Name = Name != "" ? Name : "#INVALID#";
        }
    }
}
