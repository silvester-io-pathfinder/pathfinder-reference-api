using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DistantCackle : Template
    {
        public static readonly Guid ID = Guid.Parse("e5646395-65f2-4deb-943f-1349882e56fb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Distant Cackle",
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
            yield return new TextBlock { Id = Guid.Parse("dafadc01-6478-499c-a074-10e9809e23e1"), Type = TextBlockType.Text, Text = "It takes a very brave person to enter the laughter-haunted forest where you dwell. You can cast (spell: ventriloquism) once per day as a 1st-level occult innate spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("ec6e9bf6-05e3-4c45-87bf-73d2417cd5a7"), Heritages.Instances.WitchGnoll.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f9458f2-77ce-4767-8a22-6413c9b1ce2d"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
