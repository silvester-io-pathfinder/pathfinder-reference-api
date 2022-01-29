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
    public class SpiritsWrath : Template
    {
        public static readonly Guid ID = Guid.Parse("5d6b1295-588d-4e13-afb4-6cb4fd5251ed");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spirit's Wrath",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2a703597-88ae-42db-8fd6-e781b6e20be7"), Type = TextBlockType.Text, Text = $"You call forth an ephemeral apparition, typically the ghost of an ancestor or a nature spirit, which takes the form of a wisp. The spirit wisp makes a melee wisp rush unarmed attack against an enemy within 120 feet of you. The wisp's attack modifier is equal to your proficiency bonus for martial weapons plus your Strength modifier plus a +2 item bonus, and it applies the same circumstance and status bonuses and penalties that you have. On a hit, the wisp deals damage equal to 4d8 plus your Constitution modifier. The damage is your choice of negative or positive damage; don't apply your {ToMarkdownLink<Models.Entities.Feat>("Rage", Feats.Instances.Rage.ID)} damage or your weapon specialization damage, but circumstance and status bonuses and penalties that would also affect the wisp's damage apply. If your wisp's {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} is a critical hit, the target becomes frightened 1. This attack uses and counts toward your multiple attack penalty as if you were the one attacking." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("be5857cc-4b22-406a-8789-92f62441eb17"), Instincts.Instances.SpiritInstinct.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Attack.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Barbarian.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Instinct.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Rage.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b539bcb3-7915-4692-8ddb-9ba35936f44f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
