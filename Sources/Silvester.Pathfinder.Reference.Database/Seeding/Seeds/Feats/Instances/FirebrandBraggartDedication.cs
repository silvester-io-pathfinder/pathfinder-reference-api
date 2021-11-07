using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FirebrandBraggartDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("58ec6251-27ba-4584-bf11-7c91248ee702");

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
            yield return new TextBlock { Id = Guid.Parse("60d0ff46-724f-4ce3-811e-3bf8d1408ba8"), Type = TextBlockType.Text, Text = "Your Firebrand training has taught you that achieving something is more satisfying if you boast about it first. You declare a boast about a particular skill action, such as (action: Balance), (action: Demoralize), or (action: Recall Knowledge). The first time you attempt this action within the next minute in a context the GM deems both suitably challenging and meaningful, you must roll twice and use the lower result. If you succeed at this check, you gain a +1 circumstance bonus to checks to attempt the same action for 10 minutes." };
            yield return new TextBlock { Id = Guid.Parse("05a98fa7-1c68-4a3b-a4d5-f49facc97884"), Type = TextBlockType.Text, Text = "If the chosen action can be used with multiple skills, such as (action: Identify Magic) or (action: Recall Knowledge), you must specify which skill you are using for that particular action, such as using Arcana to (action: Identify Magic | Identify Magic - Arcana), and your bonus or penalty after the boast applies only to checks using that skill for that action. Once you declare a boast about a particular action, you cannot declare a boast about the same action until the next time you make daily preparations, regardless of whether you succeed or fail at the check." };
            yield return new TextBlock { Id = Guid.Parse("083ef3e7-187e-4c1f-9a7e-2cc60c744ffc"), Type = TextBlockType.Text, Text = "Typically a challenging task is one with at least a standard DC for your level, though the difficulty may be higher depending on the situation. A meaningful context is one where the action’s success or failure is relevant to the pursuit of your goals, rather than a boast you made simply to gain a bonus later." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("4c55ac83-873f-4ff5-92d2-0ca7de7cce22"), requiredStatValue: 14, Stats.Instances.Charisma.ID);
            builder.Manual(Guid.Parse("f2503021-13f8-4dff-837d-aefc563ce0fb"), "Second mark member of the Firebrands");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4a1296d8-29bb-445f-9eb6-152d9d348805"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
