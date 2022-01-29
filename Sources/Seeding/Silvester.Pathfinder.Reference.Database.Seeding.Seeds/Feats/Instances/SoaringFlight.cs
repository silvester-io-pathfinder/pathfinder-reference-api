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
    public class SoaringFlight : Template
    {
        public static readonly Guid ID = Guid.Parse("f7e141d4-6309-4527-a0ea-e9ca42ba7108");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Soaring Flight",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("84eb66c8-4326-4bd1-a53f-c066e8caaab5"), Type = TextBlockType.Text, Text = $"To be a tengu is to be unburdened by the concerns of the world below. You grow a pair of magical wings or expand your existing ones. For 5 minutes, you gain a fly Speed equal to your land Speed or 20 feet, whichever is greater." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("4065394d-6d0a-4c2e-ab43-c3fabdb7f959"), Heritages.Instances.SkybornTengu.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("b22b55c0-a357-46a6-bbdb-d2d2b747beae"), Traits.Instances.Morph.ID);
            builder.Add(Guid.Parse("adf622b8-5311-4d68-b2dc-540d9b169d23"), Traits.Instances.Primal.ID);
            builder.Add(Guid.Parse("e2d215dc-4d3a-44a1-bda5-77738ceb1c83"), Traits.Instances.Tengu.ID);
            builder.Add(Guid.Parse("d238146d-305f-40e8-9243-ce3ee8077ffe"), Traits.Instances.Transmutation.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("20c4e80a-6e17-41ea-ad03-681620fe8fbf"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
