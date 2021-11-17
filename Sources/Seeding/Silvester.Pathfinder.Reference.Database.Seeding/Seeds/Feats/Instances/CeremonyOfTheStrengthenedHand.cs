using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CeremonyOfTheStrengthenedHand : Template
    {
        public static readonly Guid ID = Guid.Parse("fe7285f6-8e96-4c6a-a0e4-a59b918a13bb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ceremony of the Strengthened Hand",
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
            yield return new TextBlock { Id = Guid.Parse("618c94b7-3b12-4668-afa5-57c4718e9b47"), Type = TextBlockType.Text, Text = "Your exoskeleton’s weapons are even more potent. If you have a claws unarmed attack, it gains the (trait: deadly d8) trait. If you have a branch unarmed attack, it gains the (trait: shove) and (trait: trip) traits." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d8e1ba04-85e1-4f16-9ff7-f93bd678b49d"), Feats.Instances.CeremonyOfTheEvenedHand.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f3221b1e-b2d2-41f5-b0f5-38320201be9d"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
