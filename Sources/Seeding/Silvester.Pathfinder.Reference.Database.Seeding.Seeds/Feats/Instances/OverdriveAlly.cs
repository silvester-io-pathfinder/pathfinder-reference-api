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
    public class OverdriveAlly : Template
    {
        public static readonly Guid ID = Guid.Parse("9a855e08-e612-43e5-bc39-0ba06bac08fe");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Overdrive Ally",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("809249d6-8cbc-4368-9acc-87afd6cdfd0a"), Type = TextBlockType.Text, Text = $"You quickly fling some of your powered-up mechanisms to an ally, sharing your benefits with them briefly. Choose an ally within 30 feet. Until the end of their next turn, that ally's {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} deal additional damage equal to half your Intelligence modifier, or your full Intelligence modifier if you were in critical overdrive. The ally doesn't gain the increased damage from expert, master, or legendary overdrive." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6ec1015a-e7a4-4be0-8ae2-9a346bc41821"), Feats.Instances.Overdrive.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("de3c7d49-274f-4e34-b44b-757e0c653996"), Traits.Instances.Inventor.ID);
            builder.Add(Guid.Parse("cb0e4d0b-f148-482c-9703-5e6169841d5c"), Traits.Instances.Manipulate.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7d6b08d6-5bbf-4a49-ae34-1fbab4700f17"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
