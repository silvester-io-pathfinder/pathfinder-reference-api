using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FirebrandBraggartDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("f731caa3-c617-4c1d-bb92-40a168283445");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Firebrand Braggart Dedication",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the Firebrand Braggart archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fc72684a-d0f2-4098-8f1d-5ed001bf8d3a"), Type = TextBlockType.Text, Text = $"Your Firebrand training has taught you that achieving something is more satisfying if you boast about it first. You declare a boast about a particular skill action, such as {ToMarkdownLink<Models.Entities.SkillAction>("Balance", SkillActions.Instances.Balance.ID)}, {ToMarkdownLink<Models.Entities.SkillAction>("Demoralize", SkillActions.Instances.Demoralize.ID)}, or {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)}. The first time you attempt this action within the next minute in a context the GM deems both suitably challenging and meaningful, you must roll twice and use the lower result. If you succeed at this check, you gain a +1 circumstance bonus to checks to attempt the same action for 10 minutes." };
            yield return new TextBlock { Id = Guid.Parse("534396da-840a-424d-a757-1d6eae283c04"), Type = TextBlockType.Text, Text = $"If the chosen action can be used with multiple skills, such as {ToMarkdownLink<Models.Entities.SkillAction>("Identify Magic", SkillActions.Instances.IdentifyMagic.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)}, you must specify which skill you are using for that particular action, such as using Arcana to {ToMarkdownLink<Models.Entities.SkillAction>("Identify Magic", SkillActions.Instances.IdentifyMagic.ID)} Arcana, and your bonus or penalty after the boast applies only to checks using that skill for that action. Once you declare a boast about a particular action, you cannot declare a boast about the same action until the next time you make daily preparations, regardless of whether you succeed or fail at the check." };
            yield return new TextBlock { Id = Guid.Parse("80065561-6d9a-467c-8b38-df06bc9291bb"), Type = TextBlockType.Text, Text = $"Typically a challenging task is one with at least a standard DC for your level, though the difficulty may be higher depending on the situation. A meaningful context is one where the action's success or failure is relevant to the pursuit of your goals, rather than a boast you made simply to gain a bonus later." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("9cbf3b0e-9e31-4c6c-84c9-3d871a369ec5"), requiredStatValue: 14, Stats.Instances.Charisma.ID);
            builder.Manual(Guid.Parse("20e2d517-4dfd-4a4b-9888-d7677f28c7f4"), "Second mark member of the Firebrands");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("55dcf6aa-aad2-456a-b9b8-4ed34b82c555"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
