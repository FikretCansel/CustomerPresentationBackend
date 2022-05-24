import React, { useEffect, useState } from "react";

export default function Deneme() {

    const [sector, setSector] = useState("ss");

    useEffect(() => {
        /*sectorData();*/
    }, [])


    sectorData() {
        fetch('sector/getAll').then(data => {
            console.log(data.json())
            setSector(data);
        }).catch(err=>console.log("Hata var");
    }

    return (

        <div>Merhaba</div>
    );
}
