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
    public class SkyAndHeavenStance : Template
    {
        public static readonly Guid ID = Guid.Parse("4dba8906-383c-420a-af20-4db5ce1c22ec");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sky and Heaven Stance",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ef5eaeff-1d74-473f-8a96-0953df8bdc45"), Type = TextBlockType.Text, Text = $"You enter a stance perfected by past champions of the Challenge of Sky and Heaven, allowing you to make jagged strikes like flashes of lightning through the sky. The only {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} you can make are skyward slash unarmed attacks. These unarmed attacks deal 1d10 slashing damage; are in the brawling group; and have the {ToMarkdownLink<Models.Entities.Trait>("nonlethal", Traits.Instances.Nonlethal.ID)}, {ToMarkdownLink<Models.Entities.Trait>("unarmed", Traits.Instances.Unarmed.ID)}, and {ToMarkdownLink<Models.Entities.Trait>("versatile P", Traits.Instances.Versatile.ID)} traits." };
            yield return new TextBlock { Id = Guid.Parse("3ae9bcfc-5062-4da6-93fb-ace35caebdd0"), Type = TextBlockType.Text, Text = $"While in Sky and Heaven Stance, you gain resistance 2 to electricity and resistance 2 to sonic damage. These resistances increase to 5 at 12th level and to 8 at 18th level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("65e4c4e6-80ab-401a-afe4-45a759e1a5dd"), Feats.Instances.JalmeriHeavenseekerDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9574ef47-a7fa-400e-bd32-f5412fe1a6f1"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
