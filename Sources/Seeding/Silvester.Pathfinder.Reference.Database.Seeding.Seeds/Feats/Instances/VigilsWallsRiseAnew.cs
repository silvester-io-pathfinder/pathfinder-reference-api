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
    public class VigilsWallsRiseAnew : Template
    {
        public static readonly Guid ID = Guid.Parse("2b6a4e59-9b57-4611-a134-a6190a2c5c39");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vigil's Walls Rise Anew!",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fb6259e2-5256-44ea-86f3-fa7eed546266"), Type = TextBlockType.Text, Text = $"As part of daily preparation, you can drill with a number of allies up to your Charisma modifier. These allies must be present and listening during this time, but this does not otherwise impede their own preparation. When you use this feat's benefit, you and all drilled companions within 30 feet who are wielding shields {ToMarkdownLink<Models.Entities.Action>("Raise a Shield", Actions.Instances.RaiseAShield.ID)}. Allies who {ToMarkdownLink<Models.Entities.Action>("Raise their Shields", Actions.Instances.RaiseAShield.ID)} keep them raised until the start of their next turn, as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1640bdcb-784c-425d-8a5e-208a040a5cad"), Feats.Instances.KnightVigilantDedication.ID);
            builder.HaveSpecificFeat(Guid.Parse("400a42f1-b192-43e4-a48b-67cba42c86c0"), Feats.Instances.ShieldBlock.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("185ce0ca-882e-43ad-9e5c-e29ccd5ca4c2"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
