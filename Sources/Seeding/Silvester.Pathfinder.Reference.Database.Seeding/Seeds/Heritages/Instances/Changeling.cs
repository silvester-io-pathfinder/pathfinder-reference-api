using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class Changeling : Template
    {
        public static readonly Guid ID = Guid.Parse("21a9fd8d-16db-43f2-af67-bd5a97b92d8e");

        protected override Heritage GetHeritage()
        {
           return new Heritage 
           {
               Id = ID, 
               RarityId = Rarities.Instances.Uncommon.ID, 
               Name = "Changeling"
           };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7c317289-c1c5-4ddb-939c-d9c0613b3941"), Type = TextBlockType.Text, Text = "Your mother was a hag. Your heterochromatic eyes are the most obvious signifier of this parentage, but you likely also have a slighter build, paler skin, and darker hair than most members of your other parent’s ancestry. You gain the changeling trait. You also gain low-light vision, or you gain darkvision if your ancestry already has low-light vision. You can select from changeling feats and feats from your other parent’s ancestry whenever you gain an ancestry feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificTrait(Guid.Parse("5cf0e44f-0f45-4f0b-b0bf-639fcd8280b7"), Traits.Instances.Changeling.ID);
            builder.AddOr(Guid.Parse("d6201578-cf21-4579-b8d8-0de097f9ffa9"), or =>
            {
                builder.GainSpecificSense(Guid.Parse("c1724a17-a40c-41ce-b577-dcb0b07084cb"), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
                builder.GainSpecificSense(Guid.Parse("c697fd89-5835-41e7-a268-65dcf54803cf"), Senses.Instances.Darkvision.ID, SenseAccuracies.Instances.Precise.ID)
                    .AddPrerequisites(Guid.Parse("a5020f55-9ea0-428c-bb8f-d089b15731ba"), prerequisites =>
                    {
                        prerequisites.HaveSpecificSense(Guid.Parse("14431779-5634-48ce-a645-408e9348041b"), Senses.Instances.LowLightVision.ID);
                    });
            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9a6242b9-4e3b-4415-a985-391e891e13b0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 30
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Catfolk.ID;
            yield return Gnome.ID;
            yield return Goblin.ID;
            yield return Human.ID;
            yield return Tengu.ID;
            yield return Orc.ID;
            yield return Dwarf.ID;
            yield return Kobold.ID;
            yield return Ratfolk.ID;
            yield return Elf.ID;
            yield return Halfling.ID;
        }
    }
}
