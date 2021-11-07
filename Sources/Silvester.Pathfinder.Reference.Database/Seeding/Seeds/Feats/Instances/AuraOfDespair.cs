using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AuraOfDespair : Template
    {
        public static readonly Guid ID = Guid.Parse("867bc62a-7528-4f53-9ec7-f018bbc334ef");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aura of Despair",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("15ac2dfa-1d95-426a-9855-aba0c1170b22"), Type = TextBlockType.Text, Text = "Your presence as an avatar of evil makes your foes more susceptible to terror and makes it almost impossible for them to shake off fear when you are near. Enemies within 15 feet of you take a –1 circumstance penalty to saving throws against fear. In addition, an enemy that ends its turn within 15 feet of you can’t reduce the value of its frightened condition below 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificTenet(Guid.Parse("1261ae3e-bdd8-41f9-9bcd-539d898c7fbe"), Tenets.Instances.Evil.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f4f0e65d-1e68-405c-9005-95779d22794e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
