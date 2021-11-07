using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PiercingQuills : Template
    {
        public static readonly Guid ID = Guid.Parse("aa66b364-98a6-4c94-94c0-2fd71cc7745a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Piercing Quills",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7c215ed8-e765-40b4-b444-5992b9599a6a"), Type = TextBlockType.Text, Text = "Your quills can dig particularly deep into the flesh of your opponents. Your quills unarmed attack deals 1d4 persistent bleed damage on a critical hit." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0b511bc3-ea33-4752-9ae7-ed1c2c8ef905"), Feats.Instances.SpineStabber.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4c1ffc47-8ecd-4ea2-a58f-0dfef128cecb"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
