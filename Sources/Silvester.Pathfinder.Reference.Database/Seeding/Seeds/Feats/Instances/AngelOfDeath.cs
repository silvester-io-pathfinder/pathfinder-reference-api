using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AngelOfDeath : Template
    {
        public static readonly Guid ID = Guid.Parse("e28969dd-dd23-476c-9b43-7d6499066f6b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Angel of Death",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7422f709-5970-4bb4-b003-ae5d50017b53"), Type = TextBlockType.Text, Text = "All your (action: Strikes | Strike) against a creature you have (feat: Marked for Death | Mark for Death) have the (trait: death) trait, causing the mark to be instantly killed when reduced to 0 Hit Points. When killed in this way, attempts to communicate with it, return it to life, turn it into an undead, or otherwise disturb its afterlife fail unless the effect’s counteract level is higher than half your level when you killed the creature (rounded up), or originates from an artifact or a deity." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6a73463f-4ebf-4b94-b072-1ba5a816474b"), Feats.Instances.AssasinDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("277c1fa1-ede0-4d1c-9e72-ebab5fc54af0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
