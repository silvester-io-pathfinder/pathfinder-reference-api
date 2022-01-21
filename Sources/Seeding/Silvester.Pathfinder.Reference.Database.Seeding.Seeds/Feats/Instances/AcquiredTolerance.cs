using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AcquiredTolerance : Template
    {
        public static readonly Guid ID = Guid.Parse("905c0fc5-0495-435f-93ca-ae1469ba72d1");

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
            yield return new TextBlock { Id = Guid.Parse("fbc76bef-c8e6-4e17-b97e-9ca1691e59d4"), Type = TextBlockType.Text, Text = $"A small amount of poison, taken at nonlethal doses, can help the body build up a resistance against a more deadly dosage. Reroll the triggering check and use the second result. Once you use Acquired Tolerance, you can continue to use it against the same type of poison that day, but you can't use it against a different type of poison until after you make your next daily preparations. For instance, if you used the reaction on a save against {ToMarkdownLink<Models.Items.Instances.AlchemicalPoison>("giant scorpion venom", Items.AlchemicalPoisons.Instances.GiantScorpionVenom.ID)}, you could use it again against {ToMarkdownLink<Models.Items.Instances.AlchemicalPoison>("giant scorpion venom", Items.AlchemicalPoisons.Instances.GiantScorpionVenom.ID)} even if it came from a different source, but you couldn't use it against {ToMarkdownLink<Models.Items.Instances.AlchemicalPoison>("nettleweed residue", Items.AlchemicalPoisons.Instances.NettleweedResidue.ID)}, {ToMarkdownLink<Models.Items.Instances.AlchemicalPoison>("lich dust", Items.AlchemicalPoisons.Instances.LichDust.ID)}, or another poison." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("db59911a-be86-46d1-810f-49a16c0cf67e"), Feats.Instances.PoisonerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6b0089d5-c12e-4a6f-8892-0816da5d34b5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
