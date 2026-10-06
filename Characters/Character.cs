class Character:Entity {
    public string name = "Lorem";
    public CharacterClass charClass = CharacterClass.Fighter;

    public Character(int HP, int atk) {
        this.currentHP = HP;
        this.maxHP = HP;
        this.attack = atk;
    }
}