using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StudiousCapacity : Template
    {
        public static readonly Guid ID = Guid.Parse("b0600399-a041-4b4f-986f-f5e105b8ee26");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Studious Capacity",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c1c479e9-ea3e-4b7c-a20d-7ee881fac769"), Type = TextBlockType.Text, Text = "Your continued study of occult magic has increased your magical capacity, allowing you to cast spells even when it seems impossible. You can cast one spell each day even after you’ve run out of spell slots of the appropriate spell level, but you can’t use this ability to cast a spell of your highest spell level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("a07466e2-fa07-45d3-a4af-8230c0a6ec65"), Muses.Instances.Enigma.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("cff7f8d5-927b-4862-81d6-86c781c1c370"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Occultism.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("82b44f37-095e-4d6e-a8a7-822acec0caca"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
