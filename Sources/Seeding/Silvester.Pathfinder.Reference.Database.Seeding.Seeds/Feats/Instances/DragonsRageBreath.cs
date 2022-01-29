using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DragonsRageBreath : Template
    {
        public static readonly Guid ID = Guid.Parse("a3ba0242-66d0-47c9-a189-b718ca1adb75");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dragon's Rage Breath",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f4131400-2e1d-4c1f-aaed-a81626a392b1"), Type = TextBlockType.Text, Text = $"You breathe deeply and exhale powerful energy in a 30-foot cone or 60-foot line, dealing 1d6 damage per level. The area and damage type match those of your dragon (see Dragon Instincts table). If you used this ability in the last hour, the area and the damage are halved (15-foot cone or 30-foot line; 1d6 damage for every 2 levels). Each creature in the area must attempt a basic Reflex save." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("90718b7e-549f-4947-8291-ed4c0fe415d5"), Instincts.Instances.DragonInstinct.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("3a375048-1a39-45bd-819b-a66d92aecb63"), Traits.Instances.Arcane.ID);
            builder.Add(Guid.Parse("493b3200-4689-439d-8ab4-390365eb45f1"), Traits.Instances.Barbarian.ID);
            builder.Add(Guid.Parse("45dfbd16-4c54-4afb-94b1-8950118606c4"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("05be862c-d2ce-4d95-a67f-06d4ef1b9dd5"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("ba950cdf-609d-4c59-b808-a42b620c36df"), Traits.Instances.Instinct.ID);
            builder.Add(Guid.Parse("df30b470-907e-4875-8805-655efe170d60"), Traits.Instances.Rage.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("75213564-ebc4-44ac-b9e0-bc0d967deded"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
