using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CatfolkWeaponExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("a5612e69-95f0-4b5f-81d8-8be50ee2ca77");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Catfolk Weapon Expertise",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a5b884c4-bc9c-41ba-9f40-d44b7150faef"), Type = TextBlockType.Text, Text = "Whenever you gain a class feature that grants you expert or greater proficiency in certain weapons, you also gain that proficiency rank in all weapons you are trained in from (feat: Catfolk Weapon Familiarity)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("46e785b2-4233-46d6-bb0c-2e1afa645a42"), Feats.Instances.CatfolkWeaponFamiliarity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c61b9fe0-67f7-47c6-9069-f63a46231b67"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
