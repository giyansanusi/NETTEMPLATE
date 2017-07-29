using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NETTEMPLATE.Models;
using MVC_NET_CRUD_LINQ;

namespace NETTEMPLATE.Controllers
{
    public class BarangController : Controller
    {
        //
        // GET: /Barang/

        public ActionResult Index() {

            return View();

        }


        #region Razor View Engine

        #region View
        //CrudLinqBarang.dbml data context
        CrudLinqBarangDataContext db = new CrudLinqBarangDataContext();
        public ActionResult Show()
        {
            //Bikin object list, baranglist
            IList<Barang> baranglist = new List<Barang>();

            //ngambil data dari database pake LINQ
            var query = from qrs in db.BARANGs select qrs; //db.BARANGs, BARANGs merupakan nama tabel yang sebelumnya di map di dbml
            var listdata = query.ToList();

            //Masukkin data dari database ke object 'baranglist'
            foreach (var barang in listdata)
            {
                baranglist.Add(new Barang()
                {
                    // variabel sebelah kiri yang di define di class model barang, sebelah kanan variabel dari database
                    IDBARANG = barang.IDBARANG,
                    NAMABARANG = barang.NAMABARANG,
                    HARGABARANG = barang.HARGABARANG,
                    DESKRIPSI = barang.DESKRIPSI,
                });
            }
            return View(baranglist);
        }

        #endregion

        #region Create
        
        //Method ini untuk menampilkan form isian nya
        public ActionResult Create()
        {
            //pada method ini, membuat objek Barang kosong lalu mempasing objek tersebut ke view
            //di view objek tersebut akan diisi lalu di submit
            Barang barang = new Barang();
            return View(barang);
        }

        //Method ini untuk menyimpan data kedalam database
        [HttpPost]
        public ActionResult Create(Barang mod)
        {
            //membuat objek dari class tabel BARANG
            //perlu diketahui disini BARANG dan Barang beda
            //BARANG nama tabel yang di map di file dbml
            //Barang class yang ada di model (Barang.cs)
            BARANG barang = new BARANG();
            // variabel sebelah kiri yang di define di class model Barang, sebelah kanan variabel dari inputan di view
            barang.NAMABARANG = mod.NAMABARANG;
            barang.HARGABARANG = mod.HARGABARANG;
            barang.DESKRIPSI = mod.DESKRIPSI;
            db.BARANGs.InsertOnSubmit(barang);
            db.SubmitChanges();
            return RedirectToAction("Show");
        }

        #endregion

        #region Edit

        //load tampilan edit data
        [HttpGet]
        public ActionResult Edit(int IDBARANG)
        {
            Barang modelBarang = db.BARANGs.Where(val => val.IDBARANG == IDBARANG).Select(val => new Barang()
            {
                IDBARANG = val.IDBARANG,
                NAMABARANG = val.NAMABARANG,
                HARGABARANG = val.HARGABARANG,
                DESKRIPSI = val.DESKRIPSI
            }).FirstOrDefault();

            return View(modelBarang);

        }

        //method pada saat submit
        public ActionResult Edit(Barang mod)
        {
            //Membuat objek dari tabel BARANG 
            BARANG brg = db.BARANGs.Where(val => val.IDBARANG == mod.IDBARANG).First<BARANG>();

            //mengisi objek brg dengan value dari input (Barang mod)
            brg.IDBARANG = mod.IDBARANG;
            brg.NAMABARANG = mod.NAMABARANG;
            brg.HARGABARANG = mod.HARGABARANG;
            brg.DESKRIPSI = mod.DESKRIPSI;
            db.SubmitChanges();
            return RedirectToAction("Show");
        }  
  

        #endregion  

        #region Delete

        public ActionResult Delete(int IDBARANG)
        {
            Barang brg = db.BARANGs.Where(val => val.IDBARANG == IDBARANG).Select(val => new Barang()
            {
                IDBARANG = val.IDBARANG,
                NAMABARANG = val.NAMABARANG,
                HARGABARANG = val.HARGABARANG,
                DESKRIPSI = val.DESKRIPSI
            }).FirstOrDefault();

            return View(brg);
        }  

        [HttpPost]
        public ActionResult Delete(Barang mod)
        {
            BARANG brg = db.BARANGs.Where(val => val.IDBARANG == mod.IDBARANG).First<BARANG>();
            db.BARANGs.DeleteOnSubmit(brg);
            db.SubmitChanges();
            return RedirectToAction("Show");
        }  

        #endregion

        #region Detail

        public ActionResult Details(int IDBARANG) {

            Barang brg = db.BARANGs.Where(val => val.IDBARANG == IDBARANG).Select(val => new Barang()
            {
                IDBARANG = val.IDBARANG,
                NAMABARANG = val.NAMABARANG,
                HARGABARANG = val.HARGABARANG,
                DESKRIPSI = val.DESKRIPSI
            }).FirstOrDefault();

            return View(brg);
        
        }

        #endregion

        #endregion

        #region ASPX View Engine

        public ActionResult indexInAspx(){
            return View("ShowBarang");
        }

        #endregion

    }
}
