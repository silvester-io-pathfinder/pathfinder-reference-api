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
    public class FavorableWinds : Template
    {
        public static readonly Guid ID = Guid.Parse("50dce073-7f35-4c7c-8911-99d600e7533e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Favorable Winds",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a828e7a5-b0b7-4b9f-9a57-25398879157f"), Type = TextBlockType.Text, Text = $"You wrap a shell of favorable wind around a weapon you wield. On your next {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with a ranged weapon before the start of your next turn, you don't take circumstance penalties on the attack roll due to wind. In addition, if that weapon has a range increment of 10 feet or less, increase its range increment by 10 feet for that {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("64705a30-da22-429f-84cb-68686242e0e7"), Feats.Instances.VirgaMay.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("a058f531-bb76-4bd1-b782-0691c6e45338"), Traits.Instances.Air.ID);
            builder.Add(Guid.Parse("5e494003-a633-4428-b9af-c8fe7f81fe1a"), Traits.Instances.Changeling.ID);
            builder.Add(Guid.Parse("f66502d8-9b60-4853-9140-0234aa4fee39"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("d05a627b-d229-4c25-bbb1-6d5befcce413"), Traits.Instances.Occult.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4ef47dea-43b3-4df7-9aee-40c81b60a084"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
