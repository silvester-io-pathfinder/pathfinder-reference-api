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
    public class TargetingShot : Template
    {
        public static readonly Guid ID = Guid.Parse("8ddfc62c-2165-4de1-94f8-b09a5517a32f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Targeting Shot",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d81785d1-678e-435b-8ef5-c71dbe468a14"), Type = TextBlockType.Text, Text = $"You carefully track your prey's position and defenses, allowing you to follow up around obstacles that block your shot. Make a ranged weapon {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against your hunted prey. You ignore the target's concealed condition and all cover." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("49f95549-f3d5-4bc6-8f3e-db864eda2160"), Feats.Instances.HuntersAim.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("d2b83bdc-422b-47b5-9d75-d031bdac509b"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("c4bd1612-dc43-4546-9960-47eb732917d2"), Traits.Instances.Press.ID);
            builder.Add(Guid.Parse("8f334f0e-b046-4792-a2ea-ac82478cf460"), Traits.Instances.Ranger.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b7fafa2e-1925-41ad-998e-e049c13821af"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
