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
    public class LightslayerOath : Template
    {
        public static readonly Guid ID = Guid.Parse("ca3b9f5d-2596-4a35-9550-c65ab2847c5d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lightslayer Oath",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("100978b1-d6e2-407c-8cff-20e65c69ee2d"), Type = TextBlockType.Text, Text = $"You've sworn to rid the world of the self-righteousness of celestial beings. Add the following tenet to your code, after the other tenets. “You must banish or slay celestials you encounter as long as you have a reasonable chance of success; in the incredibly unlikely event you find an evil celestial, you don't have to banish or kill it.”" };
            yield return new TextBlock { Id = Guid.Parse("02aa8ae7-80fe-4e1f-b10f-c736ba60ef81"), Type = TextBlockType.Text, Text = $"When you use your champion's reaction against a celestial, the extra damage you deal with {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} increases by 1 (or by 2 at 9th level and by 3 at 16th level)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificTenet(Guid.Parse("2daf4f0f-dd3b-4d6f-b5b1-93fa6b83a5c6"), Tenets.Instances.Evil.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("fec89c41-48bd-4ff5-bd1b-18347315250d"), Traits.Instances.Champion.ID);
            builder.Add(Guid.Parse("8c11c176-8b06-4d76-8220-a481be299b9d"), Traits.Instances.Oath.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8ead631b-402a-4f75-9d04-e97b749b5260"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
