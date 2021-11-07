using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CommandUndead : Template
    {
        public static readonly Guid ID = Guid.Parse("b84770de-0469-432f-82e2-d04f42632996");

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
            yield return new TextBlock { Id = Guid.Parse("2f57371b-7834-4625-9ac0-8532aeb6894a"), Type = TextBlockType.Text, Text = "You grasp the animating force within an undead creature and bend it to your will. If the next action you use is to cast (spell: harm) targeting one undead creature, you transform the effects of that (spell: harm) spell. Instead of harm’s normal effects, the target becomes controlled by you if its level is equal to or lower than your level – 3. It can attempt a Will saving throw to resist being controlled by you. If the target is already under someone else’s command, the controlling creature also rolls a saving throw, and the undead uses the better result." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineFont(Guid.Parse("68395e4a-e688-465f-b3aa-075334cb0681"), DivineFonts.Instances.Harm.ID);
            builder.AddOr(Guid.Parse("29f1a6ef-c606-4ace-aeab-087ad261f92e"), or => 
            {
                or.HaveSpecificAlignment(Guid.Parse("cd23531e-248a-48d2-bf03-1b3d54645aef"), Alignments.Instances.LawfulEvil.ID);
                or.HaveSpecificAlignment(Guid.Parse("3c3779fd-5256-4561-8968-d50ad44191df"), Alignments.Instances.ChaoticEvil.ID);
                or.HaveSpecificAlignment(Guid.Parse("f5ef48bf-c282-453b-9354-6d5e3f089ae1"), Alignments.Instances.NeutralEvil.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("677e1ca8-e418-4176-a153-9ea20b5f98af"),
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
                Id = Guid.Parse("01a234c8-d36a-4784-970b-86c897cd2856"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
