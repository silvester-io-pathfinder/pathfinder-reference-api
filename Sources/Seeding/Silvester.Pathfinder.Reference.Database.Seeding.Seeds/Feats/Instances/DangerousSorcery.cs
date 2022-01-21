using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DangerousSorcery : Template
    {
        public static readonly Guid ID = Guid.Parse("cab25fc9-1571-40f6-a8bc-4fe83d87a064");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dangerous Sorcery",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("630e8417-e28f-409d-852b-4310a662d503"), Type = TextBlockType.Text, Text = $"Your legacy grants you great destructive power. When you {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} from your spell slots, if the spell deals damage and doesn't have a duration, you gain a status bonus to that spell's damage equal to the spell's level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("89499dfd-42f3-4293-8535-be0f1fe649df"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
