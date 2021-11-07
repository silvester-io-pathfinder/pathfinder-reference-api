using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TangledForestStance : Template
    {
        public static readonly Guid ID = Guid.Parse("907a8260-445f-4eaf-80b5-90931497f946");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tangled Forest Stance",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("684a3cec-35a2-4827-b625-6aa9db572933"), Type = TextBlockType.Text, Text = "You extend your arms like gnarled branches to interfere with your foes’ movements. You can make lashing branch unarmed attacks. These deal 1d8 slashing damage; are in the brawling group; and have the (trait: agile), (trait: finesse), (trait: nonlethal), and (trait: unarmed) traits." };
            yield return new TextBlock { Id = Guid.Parse("447160c0-5cd5-43f5-95f3-af7fa969954b"), Type = TextBlockType.Text, Text = "While you’re in Tangled Forest Stance and can act, every enemy in your reach that tries to move away from you must succeed at a Reflex save, Acrobatics check, or Athletics check against your class DC or be immobilized for that action. If you prefer, you can allow the enemy to move." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d2efad1d-35e7-4048-bb42-8aeb5ea73a49"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
