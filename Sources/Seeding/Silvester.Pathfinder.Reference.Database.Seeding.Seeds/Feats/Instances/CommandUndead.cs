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
    public class CommandUndead : Template
    {
        public static readonly Guid ID = Guid.Parse("688d79b7-645b-4cd6-b62f-6c061bd27939");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Command Undead",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5ee9dc52-8989-428f-80a2-22b486faf018"), Type = TextBlockType.Text, Text = $"You grasp the animating force within an undead creature and bend it to your will. If the next action you use is to cast {ToMarkdownLink<Models.Entities.Spell>("harm", Spells.Instances.Harm.ID)} targeting one undead creature, you transform the effects of that {ToMarkdownLink<Models.Entities.Spell>("harm", Spells.Instances.Harm.ID)} spell. Instead of harm's normal effects, the target becomes controlled by you if its level is equal to or lower than your level – 3. It can attempt a Will saving throw to resist being controlled by you. If the target is already under someone else's command, the controlling creature also rolls a saving throw, and the undead uses the better result." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineFont(Guid.Parse("90d374db-13bc-46c0-b2cc-f7f7971c450e"), DivineFonts.Instances.Harm.ID);
            builder.AddOr(Guid.Parse("9b90c1fa-0d02-40d4-be1c-9d454dc26b5b"), or => 
            {
                or.HaveSpecificAlignment(Guid.Parse("b6a40c18-b97d-40b7-af4b-5034b9d4ca94"), Alignments.Instances.LawfulEvil.ID);
                or.HaveSpecificAlignment(Guid.Parse("3ae67c7a-db53-41cc-95d5-537952020885"), Alignments.Instances.ChaoticEvil.ID);
                or.HaveSpecificAlignment(Guid.Parse("a3a36890-0993-4ffc-b0c4-8210934b7ef8"), Alignments.Instances.NeutralEvil.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Metamagic.ID);

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("a8238e89-ed72-40af-917b-23b7c5804505"),
                CriticalSuccess = "The target is unaffected and is temporarily immune for 24 hours.",
                Success = "The target is unaffected.",
                Failure = "The undead creature becomes a minion under your control. The spell gains a duration of 1 minute, but it is dismissed if you or an ally attacks the minion undead.",
                CriticalFailure = "As failure, but the duration is 1 hour.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("74ab4431-952b-4546-ac45-990851515e14"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
