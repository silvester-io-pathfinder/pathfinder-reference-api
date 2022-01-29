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
    public class MiraculousFlight : Template
    {
        public static readonly Guid ID = Guid.Parse("6c54bed0-71bc-45df-903d-5d110422c98f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Miraculous Flight",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6a0814ef-eac0-495e-8fc8-a0ff4ead690a"), Type = TextBlockType.Text, Text = $"With superior engineering and magical application, you have freed your signature vehicle from the bonds of gravity, allowing it to soar through the sky like a dragon. The vehicle gains magical propulsion and a fly Speed equal to its fastest current Speed. If your signature vehicle already had a fly Speed, reduce the distance the vehicle needs to make a 90-degree turn to half the usual length (typically half the length of the vehicle)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f240dcdc-a40d-4a84-8b77-e4af02a0816f"), Feats.Instances.VehicleMechanicDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("502ece5a-d8a2-4b04-b177-dff436042ff2"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("a83c1fc2-11b2-4d8b-9115-2f8109ac69d1"), Traits.Instances.Magical.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1d1411ce-ad69-4885-a684-6beec1698802"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
