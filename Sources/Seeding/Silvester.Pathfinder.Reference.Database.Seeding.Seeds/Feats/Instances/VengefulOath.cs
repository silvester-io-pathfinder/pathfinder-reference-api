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
    public class VengefulOath : Template
    {
        public static readonly Guid ID = Guid.Parse("b3d75a41-47ef-46ac-9428-a1bd95e9b201");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vengeful Oath",
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
            yield return new TextBlock { Id = Guid.Parse("92f1ac84-2ec8-4d93-8bf7-6093a948844d"), Type = TextBlockType.Text, Text = $"You've sworn an oath to hunt down wicked evildoers and bring them to judgment. Add the following tenet to your code after the others:" };
            yield return new TextBlock { Id = Guid.Parse("e5e6b3ed-5c1c-45e8-a13d-8090ae707db3"), Type = TextBlockType.Enumeration, Text = $" : You must hunt down and exterminate evil creatures that have committed heinous atrocities as long as you have a reasonable chance of success and aren't engaged in a mission that would prevent your doing so." };
            yield return new TextBlock { Id = Guid.Parse("5cf271bd-4d2e-4de1-8bd8-640ab05ade47"), Type = TextBlockType.Text, Text = $"You can use {ToMarkdownLink<Models.Entities.Spell>("lay on hands", Spells.Instances.LayOnHands.ID)} to damage a creature you witness harming an innocent or a good ally as if it were undead; in this case, {ToMarkdownLink<Models.Entities.Spell>("lay on hands", Spells.Instances.LayOnHands.ID)} deals good damage instead of positive damage and gains the {ToMarkdownLink<Models.Entities.Trait>("good", Traits.Instances.Good.ID)} trait. This good damage can affect non-evil creatures. This doesn't prevent you from healing such a creature with {ToMarkdownLink<Models.Entities.Spell>("lay on hands", Spells.Instances.LayOnHands.ID)}; you choose whether to heal or harm." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificCause(Guid.Parse("58d44643-b750-4ddb-8cb3-1f532cd6ad1a"), Causes.Instances.Paladin.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8f9d403d-3455-4cff-afbb-7a904e119222"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
