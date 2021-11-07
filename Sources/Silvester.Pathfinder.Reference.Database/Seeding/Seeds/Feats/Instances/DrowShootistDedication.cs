using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DrowShootistDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("9e5c4de7-5ed9-4ffb-ae25-f01f02ddecd4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Drow Shootist Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you've gained two other feats from the drow shootist archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d7e57c38-3a2c-49de-80eb-33d3294fbcd8"), Type = TextBlockType.Text, Text = "Every chance you get, you practice with the hand crossbow to increase your draw speed and accuracy. Whenever you gain a class feature that grants you expert or greater proficiency in a given weapon or weapons, you also gain that proficiency in the (item: hand crossbow). If you&#39;re at least an expert in a (item: hand crossbow) you&#39;re using, you gain access to its critical specialization effect. You also gain the (feat: Shootist&#39;s Draw) action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificRangedWeaponSpecificProficiency(Guid.Parse("0ba32f75-cde3-4131-8f84-3171b6de0a98"), Proficiencies.Instances.Trained.ID, RangedWeapons.Instances.HandCrossbow.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("557a9e65-6171-4d03-93a8-d6a4a6016b3d"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
