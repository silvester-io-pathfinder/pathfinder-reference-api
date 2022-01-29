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
    public class DestructiveBlock : Template
    {
        public static readonly Guid ID = Guid.Parse("e8976e6f-a55c-4859-ab08-5d53d7fb48e3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Destructive Block",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d6afe2d9-e2c9-4be5-80ae-eb093faf3904"), Type = TextBlockType.Text, Text = $"You can protect yourself more effectively, at the expense of your shield. When you {ToMarkdownLink<Models.Entities.Feat>("Shield Block", Feats.Instances.ShieldBlock.ID)}, you can reduce the damage to yourself by double the shield's Hardness, but if you do, the shield takes double the normal amount of damage it would have taken (before applying its Hardness). You can't use Destructive Block if your shield can't be broken or destroyed, such as if you're using an {ToMarkdownLink<Models.Items.Instances.Shield>("indestructible shield", Items.Shields.Instances.IndestructibleShield.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("59133c90-774f-4dd8-a668-f77524039adc"), Feats.Instances.BastionDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("e6cdc1ac-5086-414c-8fc7-a392e74c7182"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("85c4598d-b743-4f13-98f5-3fbe8af5554b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
