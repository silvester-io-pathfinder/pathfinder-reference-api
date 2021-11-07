using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SoulFlare : Template
    {
        public static readonly Guid ID = Guid.Parse("056812bf-c77c-4b80-bfd9-f90e1915283d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Soul Flare",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An attack you made with a soulforged weapon or shield misses a creature, or a creature hits you with an attack while you're either wearing manifested soulforged armor or have your soulforged shield raised.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c5681548-f574-4270-bd16-c3e516aeb95b"), Type = TextBlockType.Text, Text = "You strive to change the outcome with sheer zeal. You gain a +1 status bonus to your attack roll if making an attack or to your AC if you were hit. This can change the outcome of the roll. If this bonus turns your missed attack into a hit or the hit against you into a miss, attempt a DC 5 flat check. If you fail, your soulforged armament is Dismissed—your weapon if you attacked or your armor or shield if you were defending." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("95e268a2-2e5d-46d6-8851-32f07342ff8f"), Feats.Instances.SoulforgerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2a3dd779-bd5f-46d5-8a73-49b05cb1fe23"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
