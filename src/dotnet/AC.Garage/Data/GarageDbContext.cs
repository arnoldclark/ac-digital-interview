using Microsoft.EntityFrameworkCore;

namespace AC.Garage.Data;

public class GarageDbContext(DbContextOptions options) : DbContext(options);