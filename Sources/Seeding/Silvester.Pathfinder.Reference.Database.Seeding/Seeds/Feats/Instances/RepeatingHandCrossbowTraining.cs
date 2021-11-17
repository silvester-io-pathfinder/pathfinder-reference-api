using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RepeatingHandCrossbowTraining : Template
    {
        public static readonly Guid ID = Guid.Parse("8343f892-d52e-4745-aa96-659856a47aee");

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
            yield return new TextBlock { Id = Guid.Parse("f62f0ef1-6511-4ac8-83f1-2b65c8efe742"), Type = TextBlockType.Text, Text = "You become trained in the (item: repeating hand crossbow) and gain access to repeating hand crossbows and (item: shootist bandoliers | shootist bandolier). Whenever you gain a class feature that grants you expert or greater proficiency in a given weapon or weapons, you also gain that proficiency in the (item: repeating hand crossbow). If you&#39;re at least an expert in a (item: repeating hand crossbow) you&#39;re using, you gain access to its critical specialization effect. You can perform the (feat: Shootist&#39;s Draw) action with repeating hand crossbows." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d011bb42-42e9-4120-abd6-dca1724a6d7b"), Feats.Instances.DrowShootistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("60d3faa5-5cff-452b-8b6b-2e24c40f7165"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
