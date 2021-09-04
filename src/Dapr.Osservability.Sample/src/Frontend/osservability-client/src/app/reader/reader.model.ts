export class FruitVegetables{
    expirationDate!: Date;
    temperature!: Number;
    name!: string ;
    description!: string;
    quantity!: Number;
    type!: FruitVegetableType;
}

export enum FruitVegetableType {
    Fruit = '0',
    Vegetable = '1'
}