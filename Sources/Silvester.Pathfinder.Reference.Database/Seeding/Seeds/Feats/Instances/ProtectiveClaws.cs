using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ProtectiveClaws : Template
    {
        public static readonly Guid ID = Guid.Parse("5b687a0d-f648-443b-8fc5-772f10cdf9f9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Protective Claws",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c51d54b5-39c0-49a6-940a-6c627a5278a4"), Type = TextBlockType.Text, Text = "The chitin on your claws is so hard you can defend against attacks with them. Your claw unarmed attack from the vicious goloma heritage gains the (trait: parry) weapon trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("d87000da-a558-4752-a96b-744c40dec3b6"), Heritages.Instances.ViciousGoloma.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1829cc01-3968-4d24-a74a-c3fd06cc469b"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
