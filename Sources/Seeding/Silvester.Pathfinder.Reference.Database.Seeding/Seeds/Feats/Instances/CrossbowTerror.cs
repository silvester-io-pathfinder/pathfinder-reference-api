using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CrossbowTerror : Template
    {
        public static readonly Guid ID = Guid.Parse("4709599d-05c6-4cb2-bfe3-5070a578137b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Crossbow Terror",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4c330672-1f78-43e9-88e4-e95edff4a902"), Type = TextBlockType.Text, Text = "You are a dynamo with the crossbow. You gain a +2 circumstance bonus to damage with crossbows. If the crossbow is a simple weapon, also increase the damage die size for your attacks made with that crossbow by one step. As normal, this damage die increase can't be combined with other abilities that alter the weapon damage die (such as the ranger feat (feat: Crossbow Ace))." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("eaaf05cd-abd0-4230-b9fe-89f1b33d4b8e"), Feats.Instances.ArcherDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f00d755b-05d8-4c01-a7eb-ab0f444f50b3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
