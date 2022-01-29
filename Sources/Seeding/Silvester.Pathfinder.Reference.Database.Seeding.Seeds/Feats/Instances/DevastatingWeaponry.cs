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
    public class DevastatingWeaponry : Template
    {
        public static readonly Guid ID = Guid.Parse("5460bb8e-37c2-457e-bc2c-23e7dd9d8213");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Devastating Weaponry",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("26d2d36c-6116-484b-9e6e-34fa3896a65b"), Type = TextBlockType.Text, Text = $"You release a volley of projectiles from your weapon, or power it to fly in every direction across the battlefield and {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} multiple creatures. Make a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with your weapon innovation against each foe within 30 feet of you. Don't increase your multiple attack penalty until after making all the attacks. If your innovation is a melee weapon and any of the attacks are outside your reach, you {ToMarkdownLink<Models.Entities.Action>("Release", Actions.Instances.Release.ID)} the weapon before the {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)}, and it returns to your grasp after all of them. If your hands are full when the weapon returns, it falls to the ground in your space. As normal, if your weapon innovation requires one or more actions to reload between {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)}, you can't use it to make multiple attacks with Devastating Weaponry." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInnovation(Guid.Parse("bf5a69be-6d77-4da0-a0a1-e89579f73704"), Innovations.Instances.Weapon.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("09e2c74f-b41f-442e-99e2-8b331e88a38f"), Traits.Instances.Inventor.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f0f4d842-2d8e-4b34-b60a-69ad61809170"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
