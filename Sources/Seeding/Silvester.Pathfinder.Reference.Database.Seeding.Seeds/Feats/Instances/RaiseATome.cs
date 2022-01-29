using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RaiseATome : Template
    {
        public static readonly Guid ID = Guid.Parse("42017cd3-ac10-49bc-86ee-bcd11684be61");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Raise a Tome",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("035f0110-ae47-40de-ab35-b9f548e22b1b"), Type = TextBlockType.Text, Text = $"You raise up the book you're holding and flip it open to defend yourself and expedite your studies. The book remains raised until the start of your next turn. While you have a book raised, you gain a +2 circumstance bonus to AC and a +1 circumstance bonus to {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} to identify creatures using a skill related to the subject of the book (Arcana if you're using your {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("spellbook", Items.AdventuringGears.Instances.Spellbook.ID)}). This bonus is in addition to any item bonus the book normally gives to the check." };
            yield return new TextBlock { Id = Guid.Parse("34e3fe46-5a50-4384-9718-fb5eb0973fc4"), Type = TextBlockType.Text, Text = $"If you have {ToMarkdownLink<Models.Entities.Feat>("Shield Block", Feats.Instances.ShieldBlock.ID)}, you can use the tome for that feat (Hardness 3, HP 12, BT 6) as though it were a shield. Whenever you use an ability that allows you to {ToMarkdownLink<Models.Entities.Action>("Raise a Shield", Actions.Instances.RaiseAShield.ID)}, such as {ToMarkdownLink<Models.Entities.Feat>("Emergency Targe", Feats.Instances.EmergencyTarge.ID)}, you can {ToMarkdownLink<Models.Entities.Action>("Raise a Tome", Actions.Instances.RaiseAShield.ID)} instead, changing any requirements that normally require a shield to apply to your book." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c8010403-16d2-4614-b395-a15e366ec4d4"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
