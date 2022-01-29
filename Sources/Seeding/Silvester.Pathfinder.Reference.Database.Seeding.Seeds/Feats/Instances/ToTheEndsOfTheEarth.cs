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
    public class ToTheEndsOfTheEarth : Template
    {
        public static readonly Guid ID = Guid.Parse("64ba37b7-67a8-4524-a778-12428cb1c211");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "To the Ends of the Earth",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("66bdc3eb-e172-41f4-b892-5475d2e3f129"), Type = TextBlockType.Text, Text = $"Your ability to track your prey has surpassed explanation, allowing you to trace your prey's movements and predict its location with ease. When you use {ToMarkdownLink<Models.Entities.Feat>("Hunt Prey", Feats.Instances.HuntPrey.ID)} on a creature within 100 feet, you can follow that creature's movements, allowing you to know the creature's exact location no matter how far away it becomes, as long as it remains your prey. You must be legendary in Nature to track your prey's location across teleportation or planar travel. This feat gains the {ToMarkdownLink<Models.Entities.Trait>("detection", Traits.Instances.Detection.ID)}, {ToMarkdownLink<Models.Entities.Trait>("divination", Traits.Instances.Divination.ID)}, and {ToMarkdownLink<Models.Entities.Trait>("primal", Traits.Instances.Primal.ID)} traits if you're legendary in Nature." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("9ad044ab-58e9-42bb-95e9-bce2b764338a"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Survival.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("178efc3b-def5-43bb-9347-2e24d7ab7f58"), Traits.Instances.Ranger.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6cbfad51-3e64-44d5-8b7e-4c8ef2587de5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
