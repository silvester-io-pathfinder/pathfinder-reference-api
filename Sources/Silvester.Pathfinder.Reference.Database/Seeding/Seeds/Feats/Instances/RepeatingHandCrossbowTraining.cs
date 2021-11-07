using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RepeatingHandCrossbowTraining : Template
    {
        public static readonly Guid ID = Guid.Parse("0d7cd26d-2ba7-4ca1-8998-f0abb4329935");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Repeating Hand Crossbow Training",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If you have the (feat: Running Reload) feat, you can reload a (item: repeating hand crossbow) magazine on the move. You can use (feat: Running Reload) as a 3-action activity to reload a magazine into a (item: repeating hand crossbow) after you (action: Stride), (action: Step), or (action: Sneak), or as a 2-action activity if you use a magazine from a (item: shootist bandolier).",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b4419f36-cfcd-4f30-9fec-02311fe501c6"), Type = TextBlockType.Text, Text = "You become trained in the (item: repeating hand crossbow) and gain access to repeating hand crossbows and (item: shootist bandoliers | shootist bandolier). Whenever you gain a class feature that grants you expert or greater proficiency in a given weapon or weapons, you also gain that proficiency in the (item: repeating hand crossbow). If you&#39;re at least an expert in a (item: repeating hand crossbow) you&#39;re using, you gain access to its critical specialization effect. You can perform the (feat: Shootist&#39;s Draw) action with repeating hand crossbows." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("59168f52-7652-4e91-b91d-89e4687306e4"), Feats.Instances.DrowShootistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("01d92f1f-8dbf-409d-b5c5-a0346ed2da33"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
