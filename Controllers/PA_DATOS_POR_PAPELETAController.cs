using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EC3_NESTOR_ATIRO_MVCASPNET.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace EC3_NESTOR_ATIRO_MVCASPNET.Controllers
{
    public class PA_DATOS_POR_PAPELETAController : Controller
    {

        BDTRANSITO2020_EC03Context bd = new BDTRANSITO2020_EC03Context();
        public IActionResult PA_DATOS_POR_PAPELETA(string Dnipro = "", string A = "")
        {

            ViewBag.LISTA_DNI = new SelectList(bd.Propietarios.ToList(),"Dnipro","Dnipro");



            var listado = bd.pa_datos_por_datos.FromSqlRaw<PA_DATOS_POR_PAPELETA>("PA_DATOS_POR_PAPELETA {0},{1}", Dnipro, A).ToList();

            return View(listado);
        }
    }
}
