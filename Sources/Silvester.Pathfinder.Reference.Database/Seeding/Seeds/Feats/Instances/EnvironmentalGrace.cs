using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnvironmentalGrace : Template
    {
        public static readonly Guid ID = Guid.Parse("1c76123d-ec27-4990-b652-8d0fbc8ac433");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Environmental Grace",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("89314c45-9066-41c7-a43c-7a48fa0caba5"), Type = TextBlockType.Text, Text = "You rapidly adapt to environments through a combination of skill, meditation, and divine grace. After spending an hour in an environment of severe cold or colder, you are protected from the effects of severe cold until you leave that environment. After spending an hour in an environment of severe heat or hotter, you are protected from the effects of severe heat until you leave that environment." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("c2a20dd3-112e-43ef-997a-d67700cf45c3"), Proficiencies.Instances.Master.ID, Skills.Instances.Survival.ID);
            builder.AddOr(Guid.Parse("19eb9d72-fba6-45e1-8886-70c494c7834d"), or => 
            {
                or.HaveAnyDeitySpecificDomain(Guid.Parse("6d8d504f-2f00-4c7b-ad7e-15d8d9304b21"), Domains.Instances.Cold.ID);
                or.HaveAnyDeitySpecificDomain(Guid.Parse("1fd59e2e-f7de-4a77-a108-86389e7a3fb2"), Domains.Instances.Fire.ID);
                or.HaveAnyDeitySpecificDomain(Guid.Parse("bec0bc66-e1b7-4342-8cf9-7c44be728dfd"), Domains.Instances.Nature.ID);
                or.HaveAnyDeitySpecificDomain(Guid.Parse("67ba12f4-50aa-49cd-ba05-f6d6f9b9c833"), Domains.Instances.Travel.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("df966702-635b-4ee6-9b54-5bcf86e56f40"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = -1
            };
        }
    }
}
