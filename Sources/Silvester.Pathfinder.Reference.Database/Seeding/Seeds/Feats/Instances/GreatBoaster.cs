using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GreatBoaster : Template
    {
        public static readonly Guid ID = Guid.Parse("1bd83631-51c1-4091-a798-66d4c908e1db");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Great Boaster",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("528b7ba8-2b5f-4b9c-a616-647c0d34f18b"), Type = TextBlockType.Text, Text = "Your bragging is particularly effective. If you succeed at a boast, you can attempt a great boast about that same skill by using your (feat: Firebrand Braggart Dedication) action about the same action during the duration of your original boast’s circumstance bonus; this is an exception to the rule that you can’t make another boast about the same action until your next daily preparations. A great boast uses the (feat: Firebrand Braggart Dedication) action, except that if you succeed, your circumstance bonus increases to +2 and remains for 1 hour. If you fail the great boast, you take a -2 circumstance penalty to attempt the same action for 4 hours. Once you declare a great boast about a particular action, you can’t declare a great boast about the same action until the next time you make daily preparations, regardless of whether you succeed or fail at the check. The minimum challenging task for a great boast is one with at least a hard DC for your level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("bb17167a-df6a-4b51-a9e1-f8138ec7b58c"), requiredStatValue: 16, Stats.Instances.Charisma.ID);
            builder.HaveSpecificFeat(Guid.Parse("c1d17f2c-bf11-4658-b8c4-f70afeaa4e6b"), Feats.Instances.FirebrandBraggartDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b33f0248-fcc3-43b0-947e-a7a66b5a8cf5"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
