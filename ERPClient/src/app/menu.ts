export class MenuModel{
    name: string = "";
    icon: string = "";  
    url: string = "";  
    isTitle: boolean = false;
    subMenus: MenuModel[] = [];
}

export const Menus: MenuModel[] = [
    {
        name: "Ana Sayfa",
        icon: "fas fa-solid fa-home",
        url: "/",
        isTitle: false,
        subMenus: []
    },
    {
        name: "Ana Group",
        icon:"far fa-solid fa-trowel-bricks",
        url: "",
        isTitle: false,
        subMenus: [
            {
                name:"Müşterler",
                icon: "far fa-solid fa-users",
                url: "/customers",
                isTitle: false,
                subMenus: []
            },
            {
                name:"Depolar",
                icon: "far fa-solid fa-depots",
                url:"/depots",
                isTitle: false,
                subMenus:[]
            }
        ]
    }
]