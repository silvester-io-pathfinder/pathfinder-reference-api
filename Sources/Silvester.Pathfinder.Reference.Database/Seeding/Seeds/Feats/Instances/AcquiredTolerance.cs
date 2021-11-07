using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AcquiredTolerance : Template
    {
        public static readonly Guid ID = Guid.Parse("f9ed5df3-8f6e-4194-b0a7-ab7180064396");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Acquired Tolerance",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You fail a save against a poison.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("039d627c-4bbf-41e5-9c73-da1bbb382227"), Type = TextBlockType.Text, Text = "A small amount of poison, taken at nonlethal doses, can help the body build up a resistance against a more deadly dosage. Reroll the triggering check and use the second result. Once you use Acquired Tolerance, you can continue to use it against the same type of poison that day, but you can’t use it against a different type of poison until after you make your next daily preparations. For instance, if you used the reaction on a save against (item: giant scorpion venom), you could use it again against (item: giant scorpion venom) even if it came from a different source, but you couldn’t use it against (item: nettleweed residue), (item: lich dust), or another poison." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c92ff12d-df31-4200-bd03-192607f23ab5"), Feats.Instances.PoisonerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a9c337df-36a7-426c-a022-5cbf3a72b4fb"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
