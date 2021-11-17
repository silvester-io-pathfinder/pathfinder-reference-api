using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConcentratedAssault : Template
    {
        public static readonly Guid ID = Guid.Parse("0021f054-1c6e-45e1-ba87-d16575697dc6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Concentrated Assault",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("463ca755-d15b-4f99-ae40-1afa4fd1b7f4"), Type = TextBlockType.Text, Text = "You and your spotter combine your efforts to bring down your target. If you and your spotter both use the Ready activity to make a (action: Strike) against the same opponent and choose the same trigger for the readied action, resolve your attacks at the same time. Each of you can use the higher of the two attack rolls for your (action: Strikes|Strike), each using your own modifier; this is a (trait: fortune) effect. If both attacks are successful, total the damage for both attacks for the purpose of resistances and weaknesses." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e7827dd3-ae49-42ff-bbe4-127741f66597"), Feats.Instances.SnipingDuoDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("47ed1706-c0de-49e8-86ea-49e57b5059f7"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
