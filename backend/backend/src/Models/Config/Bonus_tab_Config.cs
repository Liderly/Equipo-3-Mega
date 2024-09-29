
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Models.Config
{
    public class Bonus_tab_Config :IEntityTypeConfiguration<Bonus_tab>
    {
        public void Configure(EntityTypeBuilder<Bonus_tab> builder)
        {
            builder.ToTable("Bonus_tabs");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.min_range).IsRequired();
            builder.Property(x => x.max_range).IsRequired();
            builder.Property(x => x.bonus).IsRequired();
            builder.HasData(
      new Bonus_tab { Id = 1, min_range = 0, max_range = 80, bonus = 0 },
      new Bonus_tab { Id = 2, min_range = 81, max_range = 150, bonus = 300 },
      new Bonus_tab { Id = 3, min_range = 151, max_range = 210, bonus = 500 },
      new Bonus_tab { Id = 4, min_range = 211, max_range = 300, bonus = 800 },
      new Bonus_tab { Id = 5, min_range = 301, max_range = 400, bonus = 1000 }
   );
        }
    }
}
