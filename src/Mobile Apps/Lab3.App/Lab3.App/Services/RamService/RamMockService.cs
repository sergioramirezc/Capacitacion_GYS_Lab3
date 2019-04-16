using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Lab3.Service.Computer.Data;

namespace Lab3.App.Services.RamService
{
    public class RamMockService : IRamService
    {
        IEnumerable<RAM> rams = new List<RAM>() { new RAM() { Id = 1, ItemTag = "RAM-001", SerialNumber = "7888522-999741", Standart = "DDR4", Capacity = 8, Brand = new Brand() { Id = 1, Name = "Kingston", Description = "Marca Kingston" }
                                                              , Computer = new Computer() { Id = 1, AsignedTo = "Juan Perez", Brand = new Brand () { Id = 1, Name = "HP"}, ItemTag = "PC-001", Model = "HP-OMEN-12", SerialNumber = "PQ-99-9-9-999", Processor = new Processor(){ Id = 1, Brand = new Brand() { Id = 1, Name = "INTEL"}, Cores = 6, Model = "i7-8900H", ClockSpeed = 3.1 }, Hdd = new HDD() {Id = 1, Rpm = "5400", StorageDrive = new StorageDrive() { Id = 1, Capacity = 1024, Brand = new Brand() {Id =1, Name = "Kingston" }, ItemTag ="SD-001", Model = "HQ-222" } }  }
                                                            },
                                                  new RAM() { Id = 1, ItemTag = "RAM-001", SerialNumber = "7888522-999741", Standart = "DDR4", Capacity = 8, Brand = new Brand() { Id = 1, Name = "Kingston", Description = "Marca Kingston" }
                                                              , Computer = new Computer() { Id = 1, AsignedTo = "Juan Perez", Brand = new Brand () { Id = 1, Name = "HP"}, ItemTag = "PC-001", Model = "HP-OMEN-12", SerialNumber = "PQ-99-9-9-999", Processor = new Processor(){ Id = 1, Brand = new Brand() { Id = 1, Name = "INTEL"}, Cores = 6, Model = "i7-8900H", ClockSpeed = 3.1 }, Hdd = new HDD() {Id = 1, Rpm = "5400", StorageDrive = new StorageDrive() { Id = 1, Capacity = 1024, Brand = new Brand() {Id =1, Name = "Kingston" }, ItemTag ="SD-001", Model = "HQ-222" } }  }
                                                            },
                                                  new RAM() { Id = 1, ItemTag = "RAM-001", SerialNumber = "7888522-999741", Standart = "DDR4", Capacity = 8, Brand = new Brand() { Id = 1, Name = "Kingston", Description = "Marca Kingston" }
                                                              , Computer = new Computer() { Id = 1, AsignedTo = "Juan Perez", Brand = new Brand () { Id = 1, Name = "HP"}, ItemTag = "PC-001", Model = "HP-OMEN-12", SerialNumber = "PQ-99-9-9-999", Processor = new Processor(){ Id = 1, Brand = new Brand() { Id = 1, Name = "INTEL"}, Cores = 6, Model = "i7-8900H", ClockSpeed = 3.1 }, Hdd = new HDD() {Id = 1, Rpm = "5400", StorageDrive = new StorageDrive() { Id = 1, Capacity = 1024, Brand = new Brand() {Id =1, Name = "Kingston" }, ItemTag ="SD-001", Model = "HQ-222" } }  }
                                                            },
                                                  new RAM() { Id = 1, ItemTag = "RAM-001", SerialNumber = "7888522-999741", Standart = "DDR4", Capacity = 8, Brand = new Brand() { Id = 1, Name = "Kingston", Description = "Marca Kingston" }
                                                              , Computer = new Computer() { Id = 1, AsignedTo = "Juan Perez", Brand = new Brand () { Id = 1, Name = "HP"}, ItemTag = "PC-001", Model = "HP-OMEN-12", SerialNumber = "PQ-99-9-9-999", Processor = new Processor(){ Id = 1, Brand = new Brand() { Id = 1, Name = "INTEL"}, Cores = 6, Model = "i7-8900H", ClockSpeed = 3.1 }, Hdd = new HDD() {Id = 1, Rpm = "5400", StorageDrive = new StorageDrive() { Id = 1, Capacity = 1024, Brand = new Brand() {Id =1, Name = "Kingston" }, ItemTag ="SD-001", Model = "HQ-222" } }  }
                                                            },
                                                  new RAM() { Id = 1, ItemTag = "RAM-001", SerialNumber = "7888522-999741", Standart = "DDR4", Capacity = 8, Brand = new Brand() { Id = 1, Name = "Kingston", Description = "Marca Kingston" }
                                                              , Computer = new Computer() { Id = 1, AsignedTo = "Juan Perez", Brand = new Brand () { Id = 1, Name = "HP"}, ItemTag = "PC-001", Model = "HP-OMEN-12", SerialNumber = "PQ-99-9-9-999", Processor = new Processor(){ Id = 1, Brand = new Brand() { Id = 1, Name = "INTEL"}, Cores = 6, Model = "i7-8900H", ClockSpeed = 3.1 }, Hdd = new HDD() {Id = 1, Rpm = "5400", StorageDrive = new StorageDrive() { Id = 1, Capacity = 1024, Brand = new Brand() {Id =1, Name = "Kingston" }, ItemTag ="SD-001", Model = "HQ-222" } }  }
                                                            },
                                                };
        public async Task<IEnumerable<RAM>> GetRAMs()
        {
            return rams;
        }
    }
}
